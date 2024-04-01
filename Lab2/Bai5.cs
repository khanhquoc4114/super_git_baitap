using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Xml;
using System.ComponentModel;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        class Phim
        {
            public string TenPhim { get; set; } = "";
            public int GiaVeChuan { get; set; } = 0;
            public int[] PhongChieu { get; set; } = [1, 2, 3];
            public Dictionary<int, string> GheDaChon { get; set; } 

            public Phim(){
                GheDaChon = [];
                for(int i = 0;i< PhongChieu.Length; i++)
                {
                    GheDaChon.Add(PhongChieu[i], "");
                }
            }

            public Phim(string tenphim1, int giachuan1, int[] phong1)
            {
                TenPhim = tenphim1;
                GiaVeChuan = giachuan1;
                PhongChieu = phong1;
            }
        }

        class ThongTin
        {
            public string TenPhim { set; get; } = "";
            public int SoLuongVeTon { get; set; } = 0;
            public int SoLuongVeBan { get; set; } = 0;
            public float TiLeVeBan { get; set; } = 0;
            public int DoanhThu { get; set; } = 0;
            public int XepHang { get; set; } = 0;

            public void SetThongTin(Phim data)
            {
                TenPhim = data.TenPhim;
            }
        }

        List<ThongTin> danhsachThongTin = new List<ThongTin>();
        List<Phim> phims = new List<Phim>();

        public Bai5()
        {
            InitializeComponent();
            btnOpen.Focus();
            gbChair.SendToBack();

            List<CheckBox> checkBoxes = gbChair.Controls.OfType<CheckBox>().ToList();
            foreach (CheckBox cb in checkBoxes)
            {
                cb.CheckedChanged += cb_CheckedChanged;
            }
            var tiendong = new CultureInfo("vi-VN");
            int zero = 0;
            txtMoney.Text = zero.ToString("C", tiendong);
        }
        //
        // button Xuất file json
        //
        private void btnOut_Click(object sender, EventArgs e)
        {
            if (cbSelectPhim.DataSource == null)
            {
                MessageBox.Show("Chọn dữ liệu xuất file json.");
                return;
            }

            var phims = (List<Phim>)cbSelectPhim.DataSource;

            // Thông tin được xuất
            var exportData = phims.Select(p => new
            {
                p.TenPhim,
                p.GheDaChon
            }).ToList();

            if (phims == null || phims.Count == 0)
            {
                MessageBox.Show("Không có thông tin phim.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save JSON File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    string jsonString = JsonSerializer.Serialize(exportData, new JsonSerializerOptions { WriteIndented = true});
                    File.WriteAllText(filePath, jsonString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message);
                }
            }
        }
        //
        // button mở file json
        //
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new(openFileDialog.FileName, FileMode.Open);
                cbSelectPhim.Enabled = true;
                phims = JsonSerializer.Deserialize<List<Phim>>(fileStream);
                cbSelectPhim.DataSource = phims;
                cbSelectPhim.DisplayMember = "TenPhim";
            }
        }
        //
        // Button mua vé 
        //
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                txtName.Focus();
                return;
            }
            Phim selectedPhim = cbSelectPhim.SelectedItem as Phim;
            var thongtin = "Họ tên: " + txtName.Text + "\n" +
                "Tên phim: " + selectedPhim.TenPhim + "\n" +
                "Danh sách ghế: " + txtChair.Text + "\n" +
                "Thành tiền: " + txtMoney.Text;
            MessageBox.Show(thongtin);

            List<CheckBox> checkBoxes = gbChair.Controls.OfType<CheckBox>().ToList();
            foreach (CheckBox cb in checkBoxes)
            {
                if (cb.Checked)
                {
                    cb.Checked = false;
                    cb.Enabled = false;
                    var tiendong = new CultureInfo("vi-VN");
                    int zero = 0;
                    txtMoney.Text = zero.ToString("C", tiendong);
                }
            }
            int selectedPhong = int.Parse(cbSelectRoom.Text);
            selectedPhim.GheDaChon[selectedPhong] += txtChair.Text;
            txtChair.Clear();
        }
        //
        // Chỉnh thay đổi khi nhấn checkbox hiện thông tin đã chọn
        //
        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectPhim.Items == null || cbSelectPhim.Text == "")
            {
                MessageBox.Show("Chưa có thông tin phim", "Thông báo");
                btnOpen.Focus();
                return;
            }
            var tiendong = new CultureInfo("vi-VN");
            if (sender is CheckBox)
            {
                CheckBox checkBox = (CheckBox)sender;

                if (checkBox.Checked)
                {
                    txtChair.Text += checkBox.Text + " ";
                }
                else
                {
                    string checkBoxText = checkBox.Text + " ";
                    txtChair.Text = txtChair.Text.Replace(checkBoxText, "");
                    if (txtChair.Text == "")
                    {
                        int zero = 0;
                        txtMoney.Text = zero.ToString("C", tiendong);
                    }
                }
                int sum = 0;
                Phim selectedPhim = cbSelectPhim.SelectedItem as Phim;
                List<CheckBox> checkBoxes = gbChair.Controls.OfType<CheckBox>().ToList();
                foreach (CheckBox cb in checkBoxes)
                {
                    if (cb.Checked == true)
                    {
                        string Ghe = cb.Text;
                        int soTTGhe = int.Parse(cb.Text[1].ToString());
                        int giaVeChuan = selectedPhim.GiaVeChuan;
                        if ((soTTGhe == 1 || soTTGhe == 5))
                        {
                            sum += giaVeChuan / 4;
                        }
                        else if (Ghe == "B2" || Ghe == "B3" || Ghe == "B4")
                        {
                            sum += giaVeChuan * 2;
                        }
                        else
                        {
                            sum += giaVeChuan;
                        }
                        var formatted = sum.ToString("C", tiendong);
                        formatted = formatted.Replace(",00", "");
                        txtMoney.Text = formatted.ToString();
                    }
                }
            }
        }
        //
        // button Exit
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn đóng chương trình chứ?",
                "Question?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
        //
        // Xoá hết
        //
        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (var checkbox in gbChair.Controls.OfType<CheckBox>())
            {
                checkbox.Checked = false;
                checkbox.Enabled = true;
            }
        }

        private void cbSelectPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.PerformClick();
            cbSelectRoom.Enabled = true;
            var phim = cbSelectPhim.SelectedItem as Phim;
            var phongchieu = phim.PhongChieu;
            cbSelectRoom.DataSource = phongchieu;
        }

        private void cbSelectRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.PerformClick();
            cbSelectRoom.Enabled = true;
            var phim = cbSelectPhim.SelectedItem as Phim;
            var phongchieu = phim.PhongChieu;
            cbSelectRoom.DataSource = phongchieu;
        }

    }
}
