using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            dtpkPick.CustomFormat = "dd/MM/yyyy";   
        }
        private void Bai6_Load(object sender, EventArgs e)
        {
            dtpkPick.Value = DateTime.Now;
        }

        private bool IsValidDate(int day, int month, int year)
        {
            if (year < 1900 || year > 2050)
            {
                return false;
            }

            if (month < 1 || month > 12)
            {
                return false;
            }

            int[] daysInMonth = { 31, 28 + (DateTime.IsLeapYear(year) ? 1 : 0), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day < 1 || day > daysInMonth[month - 1])
            {
                return false;
            }
            return true;
        }

        private void dtP_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpkPick.Value;

            txtDay.Text = date.Day.ToString();
            txtMonth.Text = date.Month.ToString();
            txtYear.Text = date.Year.ToString();

            string strday = txtDay.Text;
            string strmonth = txtMonth.Text;

            int day = int.Parse(strday);
            int month = int.Parse(strmonth);

            string zodiacSign;
            switch (month)
            {
                case 1:
                    zodiacSign = (day <= 20) ? "Ma Kết" : "Bảo Bình";
                    break;
                case 2:
                    zodiacSign = (day <= 19) ? "Bảo Bình" : "Song Ngư";
                    break;
                case 3:
                    zodiacSign = (day <= 20) ? "Song Ngư" : "Bạch Dương";
                    break;
                case 4:
                    zodiacSign = (day <= 20) ? "Bạch Dương" : "Kim Ngưu";
                    break;
                case 5:
                    zodiacSign = (day <= 21) ? "Kim Ngưu" : "Song Tử";
                    break;
                case 6:
                    zodiacSign = (day <= 21) ? "Song Tử" : "Cự Giải";
                    break;
                case 7:
                    zodiacSign = (day <= 22) ? "Cự Giải" : "Sư Tử";
                    break;
                case 8:
                    zodiacSign = (day <= 22) ? "Sư Tử" : "Xử Nữ";
                    break;
                case 9:
                    zodiacSign = (day <= 23) ? "Xử Nữ" : "Thiên Bình";
                    break;
                case 10:
                    zodiacSign = (day <= 23) ? "Thiên Bình" : "Thần Nông";
                    break;
                case 11:
                    zodiacSign = (day <= 22) ? "Thần Nông" : "Nhân Mã";
                    break;
                case 12:
                    zodiacSign = (day <= 21) ? "Nhân Mã" : "Ma Kết";
                    break;
                default:
                    zodiacSign = "Không xác định";
                    break;
            }
            txtZodiac.Text = zodiacSign;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Lấy số liệu ngày tháng năm nhập từ user
            string strday = txtDay.Text.Trim();
            string strmonth = txtMonth.Text.Trim();
            string stryear = txtYear.Text.Trim();
            // Khởi tạo biến bool kiểm tra kiểu dữ liệu
            bool isDay = int.TryParse(strday, out int day);
            bool isMonth = int.TryParse(strmonth, out int month);
            bool isYear = int.TryParse(stryear, out int year);

            if (!(isDay&&isMonth&&isYear))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                foreach (Control control in Controls)
                {
                    if (control is TextBox )
                    {
                        ((TextBox)control).Clear();
                    }
                }
                dtpkPick.Focus();
                return;
            }
            //Kiểm tra tính hợp lệ của ngày tháng năm
            if (!IsValidDate(day, month, year)) {
                MessageBox.Show("Ngày tháng không phù hợp!");
                dtpkPick.Focus();
                return;
            }
            //Khởi tạo ngày được chọn và gán vào dateTimePicker
            DateTime chosenDate = new DateTime(year, month, day);
            dtpkPick.Value = chosenDate;
            //Chạy điều kiện xuất cung hoàng đạo
            string zodiacSign;
            switch (month)
            {
                case 1:
                    zodiacSign = (day <= 20) ? "Ma Kết" : "Bảo Bình";
                    break;
                case 2:
                    zodiacSign = (day <= 19) ? "Bảo Bình" : "Song Ngư";
                    break;
                case 3:
                    zodiacSign = (day <= 20) ? "Song Ngư" : "Bạch Dương";
                    break;
                case 4:
                    zodiacSign = (day <= 20) ? "Bạch Dương" : "Kim Ngưu";
                    break;
                case 5:
                    zodiacSign = (day <= 21) ? "Kim Ngưu" : "Song Tử";
                    break;
                case 6:
                    zodiacSign = (day <= 21) ? "Song Tử" : "Cự Giải";
                    break;
                case 7:
                    zodiacSign = (day <= 22) ? "Cự Giải" : "Sư Tử";
                    break;
                case 8:
                    zodiacSign = (day <= 22) ? "Sư Tử" : "Xử Nữ";
                    break;
                case 9:
                    zodiacSign = (day <= 23) ? "Xử Nữ" : "Thiên Bình";
                    break;
                case 10:
                    zodiacSign = (day <= 23) ? "Thiên Bình" : "Thần Nông";
                    break;
                case 11:
                    zodiacSign = (day <= 22) ? "Thần Nông" : "Nhân Mã";
                    break;
                case 12:
                    zodiacSign = (day <= 21) ? "Nhân Mã" : "Ma Kết";
                    break;
                default:
                    zodiacSign = "Không xác định";
                    break;
            }
            txtZodiac.Text = zodiacSign;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn đóng chương trình chứ?",
                "Bai6",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }


    }
}
