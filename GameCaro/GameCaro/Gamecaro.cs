using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameCaro
{
    public partial class GameCaro : Form
    {
        #region Properties
        GameBoard board;
        SocketManager socket;
        string PlayerName;
        int room;
        int gameMode;
        string getName;

        public int Room { get => room; set => room = value; }
        public int GameMode { get => gameMode; set => gameMode = value; }
        internal SocketManager Socket { get => socket; set => socket = value; }
        public string GetName { get => getName; set => getName = value; }

        public GameCaro()
        {
            InitializeComponent();

            board = new GameBoard(pn_GameBoard, tb_PlayerName);
            //Vẽ bàn cờ
            board.PlayerClicked += Board_PlayerClicked;
            //Thêm event click bàn cờ
            board.GameOver += Board_GameOver;
            //Thêm event khi kết thúc game
            pgb_CountDown.Step = Constance.CountDownStep;
            pgb_CountDown.Maximum = Constance.CountDownTime;
            tm_CountDown.Interval = Constance.CountDownInterval;

            Socket = new SocketManager();
            
            tb_Chat.Text = "";

            NewGame();
        }
        #endregion

        #region Methods
        void NewGame()
        {
            pgb_CountDown.Value = 0;
            tm_CountDown.Stop();

            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = true;

            btn_Undo.Enabled = true;
            btn_Redo.Enabled = true;

            board.DrawGameBoard();
        }

        void EndGame()
        {
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            btn_Undo.Enabled = false;
            btn_Redo.Enabled = false;

            tm_CountDown.Stop();
            pn_GameBoard.Enabled = false;
        }

        private void GameCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            else
            {
                try
                {
                    Socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        //Khi người chơi đánh cờ
        private void Board_PlayerClicked(object sender, BtnClickEvent e)
        {
            tm_CountDown.Start();
            //Thanh thời gian bắt đầu đếm
            pgb_CountDown.Value = 0;
            //Đặt thời gian lại từ đầu
            

            if (board.PlayMode == 1)
            {//Nếu là đang đánh qua LAN
                try
                {
                    pn_GameBoard.Enabled = false;
                    Socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
                    //Sẽ gửi nước cờ đến người chơi khác

                    undoToolStripMenuItem.Enabled = false;
                    redoToolStripMenuItem.Enabled = false;

                    btn_Undo.Enabled = false;
                    btn_Redo.Enabled = false;

                    Listen();//Và tiếp tục lắng nghe
                }
                catch
                {
                    EndGame();
                    MessageBox.Show("Không có kết nối nào tới máy đối thủ", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Board_GameOver(object sender, EventArgs e)
        {//Hàm sẽ được gọi khi có người chơi thắng
            EndGame();

            if (board.PlayMode == 1)
                Socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
            //Gửi thông điệp chiến thắng đến người chơi khác
        }

        private void Tm_CountDown_Tick(object sender, EventArgs e)
        {
            pgb_CountDown.PerformStep();

            if (pgb_CountDown.Value >= pgb_CountDown.Maximum)
            {
                EndGame();

                if (board.PlayMode == 1)
                    Socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        #region MenuStrip

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();

            if (board.PlayMode == 1)
            {
                try
                {
                    Socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                }
                catch { }
            }

            pn_GameBoard.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.Undo();

            if (board.PlayMode == 1)
                Socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.Redo();

            if (board.PlayMode == 1)
                Socket.Send(new SocketData((int)SocketCommand.REDO, "", new Point()));
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Khi form 
        private void viaLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.PlayMode = 1;
            NewGame();

            Socket.IP = tb_IP.Text;

            if (!Socket.ConnectServer()) // Kết nối thử đến server xem đã có chưa
            {//Nếu chưa form này sẽ được xem như là server
                Socket.IsServer = true;
                pn_GameBoard.Enabled = false;
                Socket.CreateServer();
                //Tạo server
                Player player = new Player(getName, Image.FromFile(Application.StartupPath + "\\Resources\\X.png"));
                board.ListPlayers[0] = player;
                tb_PlayerName.Text = player.Name;
                btn_Play.Visible = true;
                MessageBox.Show("Bạn đã tạo phòng " + room.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {//Ngược lại form này sẽ được xem n hư là client
                Socket.IsServer = false;
                pn_GameBoard.Enabled = false;
                tb_PlayerName.Text = "";
                Listen();
                //Client bắt đầu lắng nghe từ server 
                Socket.Send(new SocketData((int)SocketCommand.SEND_NAME, getName, new Point()));
                //Gửi tên đến server
                Player player = new Player(getName, Image.FromFile(Application.StartupPath + "\\Resources\\O.png"));
                board.ListPlayers[1] = player;
                MessageBox.Show("Bạn đã tham gia phòng " + room.ToString() + "\nVui lòng chờ đối thủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btn_Send.Enabled = false;
        }

        private void onSameComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (board.PlayMode == 1)
            {
                try
                {
                    Socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }

                Socket.CloseConnect();
                MessageBox.Show("Đã ngắt kết nối mạng LAN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            board.PlayMode = 2;
            NewGame();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (board.PlayMode == 1)
            {
                if (board.PlayMode == 1)
                {
                    try
                    {
                        Socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    }
                    catch { }

                    Socket.CloseConnect();
                    MessageBox.Show("Đã ngắt kết nối mạng LAN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            board.PlayMode = 3;
            NewGame();
            board.StartAI();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem_Click(sender, e);
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem_Click(sender, e);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {//Khi gửi tin nhắn
            if (board.PlayMode != 1)
                return;

            PlayerName = board.ListPlayers[Socket.IsServer ? 0 : 1].Name;
            if (tb_Message.Text == "")
                return;
            tb_Chat.Text += "- " + PlayerName + ": " + tb_Message.Text + "\r\n";

            Socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, "- " + PlayerName + ": " + tb_Message.Text + "\r\n", new Point()));
            //Sẽ gửi đoạn tin đoán cùng với tên người chơi
            tb_Message.Text = "";
            Listen();//Sau đó tiếp tục lắng nghe
        }
        private void btn_Play_Click(object sender, EventArgs e)
        {
            Listen();//Server sẽ bắt đầu lắng nghe từ client
        }
        #endregion

        #region LAN settings

        //Khi form khởi động sẽ gọi đến hàm GameCaro_Shown để vào kiểu chơi đã chọn trước
        private void GameCaro_Shown(object sender, EventArgs e)
        {
            //tb_IP.Text = Socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            tb_IP.Text = "127.0.0.1";


            tb_Port.Visible = false;
            lbl_Port.Visible = false;

            if (string.IsNullOrEmpty(tb_IP.Text))
                //tb_IP.Text = Socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
                tb_IP.Text = "127.0.0.1";

            if (GameMode == 1)
            {
                tb_Port.Visible = true;
                lbl_Port.Visible = true;
                Socket.Port = room;
                tb_Port.Text = Socket.Port.ToString();
                viaLANToolStripMenuItem.PerformClick();
                //Dẫn đến hàm tạo kết nối 
            }

            if (GameMode == 2)
            {
                onSameComputerToolStripMenuItem.PerformClick();
            }

            if (GameMode == 3)
            {
                playerToolStripMenuItem.PerformClick();
            }

        }

        private void Listen()
        {
            Thread ListenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)Socket.Receive();
                    //Nhận dữ liệu và xử lý sau khi nhận
                    //Kiểu dữ liệu nhận được là SocketData đã được tạo
                    ProcessData(data);
                }
                catch { }
            });

            ListenThread.IsBackground = true;
            ListenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            PlayerName = board.ListPlayers[board.CurrentPlayer == 1 ? 0 : 1].Name;

            switch (data.Command)
            {
                case (int)SocketCommand.SEND_POINT: //Khi dữ liệu nhận được có kiểu là SEND_POINT
                    this.Invoke((MethodInvoker)(() =>
                    {
                        board.OtherPlayerClicked(data.Point);
                        //Hàm OtherPlayerClicked sẽ được gọi để set quân cờ của đối thủ
                        pn_GameBoard.Enabled = true;

                        pgb_CountDown.Value = 0;
                        tm_CountDown.Start();

                        undoToolStripMenuItem.Enabled = true;
                        redoToolStripMenuItem.Enabled = true;

                        btn_Undo.Enabled = true;
                        btn_Redo.Enabled = true;
                    }));
                    break;

                case (int)SocketCommand.SEND_MESSAGE://Khi dữ liệu nhận được có kiểu là SEND_MASSAGE
                    WriteTextSafe(data.Message, tb_Chat);
                    //Cập nhật lại khung chat 
                    //WriteTextSafe để tránh lỗi xen ngang giữa các luồng
                    break;

                case (int)SocketCommand.NEW_GAME://Khi dữ liệu nhận được có kiểu là NEW_MASSAGE
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pn_GameBoard.Enabled = false;
                        //Bắt đầu ván mới và người gửi thông điệp sẽ được đánh trước
                    }));
                    break;

                case (int)SocketCommand.UNDO://Khi dữ liệu nhận được có kiểu là UNDO
                    this.Invoke((MethodInvoker)(() =>
                    {
                        board.Undo();
                        //Lùi lại bước mà người gửi đã đi trước đó và người gửi sẽ được đánh lại
                    }));
                    break;

                case (int)SocketCommand.REDO://Khi dữ liệu nhận được có kiểu là REDO
                    this.Invoke((MethodInvoker)(() =>
                    { 
                        board.Redo();
                        //Tiến lên bước mà người gửi đã lùi trước đó và người gửi sẽ được đánh tiếp
                    }));
                    break;

                case (int)SocketCommand.END_GAME://Khi dữ liệu nhận được có kiểu là END_GAME
                    this.Invoke((MethodInvoker)(() =>
                    {
                        if (tb_PlayerName.Text == board.ListPlayers[0].Name)
                            tb_PlayerName.Text = board.ListPlayers[1].Name;
                        else
                            tb_PlayerName.Text = board.ListPlayers[0].Name;
                        //Kiểm tra xem ai là người chiến thắng
                        EndGame();
                        MessageBox.Show(tb_PlayerName.Text + " đã chiến thắng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;

                case (int)SocketCommand.TIME_OUT://Khi dữ liệu nhận được có kiểu là TIME_OUT
                    this.Invoke((MethodInvoker)(() =>
                    {
                        if (tb_PlayerName.Text == board.ListPlayers[0].Name)
                            tb_PlayerName.Text = board.ListPlayers[1].Name;
                        else
                            tb_PlayerName.Text = board.ListPlayers[0].Name;
                        //Kiểm tra xem ai là người chiến thắng
                        EndGame();
                        MessageBox.Show("Hết giờ rồi!!!\n" + tb_PlayerName.Text + " đã chiến thắng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;

                case (int)SocketCommand.QUIT://Khi dữ liệu nhận được có kiểu là QUIT
                    this.Invoke((MethodInvoker)(() =>
                    {
                        tm_CountDown.Stop();
                        EndGame();
                        board.PlayMode = 2;
                        Socket.CloseConnect();
                        //Kết thúc khỏi ván cờ và ngắt kết nối
                        MessageBox.Show("Đối thủ đã thoát phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;
                case (int)SocketCommand.SEND_NAME://Khi dữ liệu nhận được có kiểu là SEND_NAME
                    this.Invoke((MethodInvoker)(() =>
                    {
                        if (Socket.IsServer)//Kiểm tra xem có phải là server hay không
                        {//Nếu là server dữ liệu được nhận là từ client sẽ đổi tên người chơi thứ 2 
                            pn_GameBoard.Enabled = true;
                            Player player = new Player(data.Message, Image.FromFile(Application.StartupPath + "\\Resources\\O.png"));
                            board.ListPlayers[1] = player;//Đổi tên người chơi
                            btn_Play.Enabled = false;
                            btn_Play.Visible = false;
                            Socket.Send(new SocketData((int)SocketCommand.SEND_NAME, getName, new Point()));
                            //Gửi tên đến người chơi khác
                        }
                        else
                        {//ngược lại dữ liệu được nhận là từ server sẽ đổi tên người chơi thứ nhất
                            Player player = new Player(data.Message, Image.FromFile(Application.StartupPath + "\\Resources\\X.png"));
                            board.ListPlayers[0] = player;
                            tb_PlayerName.Text = player.Name;
                        }
                        Listen();//Tiếp tục lắng nghe
                        btn_Send.Enabled = true;
                    }));
                    break;

                default:
                    break;
            }

            Listen();//Sau khi xử lý xong dữ liệu sẽ tiếp tục lắng nghe như 1 vòng lặp trong luồng Listen
        }

        private delegate void SafeCallDelegate(string text, Control obj);
        private void WriteTextSafe(string text, Control control)
        {
            if (control.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                control.Invoke(d, new object[] { text, control });
            }
            else
            {
                ((TextBox)control).Text += text;
            }
        }


        #endregion

        #endregion

    }
}
