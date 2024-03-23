using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        class Phim
        {
            public string tenphim { get; set; }
            public int giavechuan { get; set; }
            public int[] phong { get; set; }
            public Phim()
            {
                tenphim = "";
                giavechuan = 0;
                phong = new int[] { 1, 2, 3 };
            }
            public Phim(string tenphim1, int giachuan1, int[] phong1)
            {
                tenphim = tenphim1;
                giavechuan = giachuan1;
                phong = phong1;
            }
        }

        public Bai4()
        {
            InitializeComponent();
            Phim phim1 = new Phim("Đào, phở và piano", 45000, [1, 2, 3]);
            Phim phim2 = new Phim("Mai", 100000, [2, 3]);
            Phim phim3 = new Phim("Gặp lại vợ bầu", 70000, [1]);
            Phim phim4 = new Phim("Tarot", 90000, [3]);

            List<Phim> phims = [phim1, phim2, phim3, phim4];
            cbSelectPhim.DataSource = phims;
            cbSelectPhim.DisplayMember = "tenphim";
            gbChair.SendToBack();

            List<System.Windows.Forms.CheckBox> checkBoxes = gbChair.Controls.OfType<System.Windows.Forms.CheckBox>().ToList();
            foreach (System.Windows.Forms.CheckBox cb in checkBoxes)
            {
                cb.CheckedChanged += cb_CheckedChanged;
            }
            var tiendong = new CultureInfo("vi-VN");
            int zero = 0;
            txtMoney.Text = zero.ToString("C", tiendong);
        }
        //
        //Buy Button
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
            List<System.Windows.Forms.CheckBox> checkBoxes = gbChair.Controls.OfType<System.Windows.Forms.CheckBox>().ToList();
            var thongtin = "Họ tên: " + txtName.Text + "\n" +
                "Tên phim: " + selectedPhim.tenphim + "\n" +
                "Danh sách ghế: " + txtChair.Text + "\n" +
                "Thành tiền: " + txtMoney.Text;
            MessageBox.Show(thongtin);
            foreach (System.Windows.Forms.CheckBox cb in checkBoxes)
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
            txtChair.Clear();
        }
        //
        // Chỉnh thay đổi khi nhấn checkbox hiện thông tin đã chọn
        //
        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            var tiendong = new CultureInfo("vi-VN");
            if (sender is System.Windows.Forms.CheckBox)
            {
                System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;

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
                List<System.Windows.Forms.CheckBox> checkBoxes = gbChair.Controls.OfType<System.Windows.Forms.CheckBox>().ToList();
                foreach (System.Windows.Forms.CheckBox cb in checkBoxes)
                {
                    if (cb.Checked == true)
                    {
                        string Ghe = cb.Text;
                        int soTTGhe = int.Parse(cb.Text[1].ToString());
                        int giaVeChuan = selectedPhim.giavechuan;
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
        //Exit
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
        //Xoá hết
        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (var checkbox in gbChair.Controls.OfType<System.Windows.Forms.CheckBox>())
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
            var phongchieu = phim.phong;
            cbSelectRoom.DataSource = phongchieu;
        }

        private void cbSelectRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.PerformClick();
            cbSelectRoom.Enabled = true;
            var phim = cbSelectPhim.SelectedItem as Phim;
            var phongchieu = phim.phong;
            cbSelectRoom.DataSource = phongchieu;
        }
    }
}
