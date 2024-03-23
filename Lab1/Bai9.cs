using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
            txtNum.KeyDown += txtNum_KeyDown;
        }

        private void Bai9_Load(object sender, EventArgs e)
        {

        }
        //
        //Hàm tách chuỗi theo cụm 3 số
        //
        static List<string> CatChuoi(string input, int groupSize) 
        {
            List<string> result = new List<string>();
            int length = input.Length;

            for (int i = length; i > 0; i -= groupSize)
            {
                int startIndex = Math.Max(0, i - groupSize);
                int endIndex = i - startIndex;

                string group = input.Substring(startIndex, endIndex);
                result.Insert(0, group);
            }

            return result;
        }
        //Hàm đọc 3 số
        static string DocHangTram(string baso)
        {
            List<string> numbers = new List<string> { "Không", "Một", "Hai", "Ba",
        "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" }; //Chuỗi số string
            string doc = "";
            int num = int.Parse(baso); //Đổi string thành int
            if (num == 0) return "";

            if (num >= 100 && num <= 999) //Giải quyết > 100
            {
                doc += numbers[num / 100] + " Trăm "; // doc + hàng trăm

                if ((num % 100) == 0) return doc; // Xử lý trường hợp XX00

                if ((num % 100) / 10 == 0 && num % 10 != 0)
                {
                    doc += "Lẻ " + numbers[num % 10];
                }
                //Nằm khoảng 10 - 19 
                else if (num % 100 >= 10 && num % 100 <= 19)
                {
                    if (num % 100 == 15) doc += "Mười Lăm";
                    else doc += "Mười " + numbers[num % 10];
                }
                //hàng chục > 1
                else if ((num % 100) / 10 != 0 && (num % 100) / 10 > 1)
                {
                    if (num % 10 == 5) doc += numbers[(num % 100) / 10] + " Mươi Lăm";
                    else if (num % 10 == 1) doc += numbers[(num % 100) / 10] + " Mươi Mốt";
                    else
                    {
                        doc += numbers[(num % 100) / 10] + " Mươi";
                        if (num % 10 != 0)
                        {
                            doc += " " + numbers[num % 10];
                        }
                    }
                }
            }
            else if (num > 10 && num < 100)
            { // Giải quyết 10 < x < 100
                doc += "Lẻ ";
                if (num >= 20)
                {
                    doc += numbers[num / 10] + " Mươi";
                }
                else
                {
                    doc += "Mười";
                }
                int donvi = num % 10;
                if (donvi == 0) return doc;
                else doc += " " + numbers[num % 10];
            }
            else // Giải quyết < 10
            {
                if (num == 10) return "Mười";
                doc += "Lẻ ";
                doc += numbers[num];
            }
            return doc;
        }
        //
        //Button thực thi 
        //
        private void btnRead_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            string doc = "";
            string txtnum = txtNum.Text.Trim();
            txtnum = txtnum.Replace(" ", "");

            if ((!Int64.TryParse(txtnum, out Int64 result) && txtnum != ""))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
                txtNum.SelectAll();
                return;
            }
            if (txtnum == "")
            {
                MessageBox.Show("Vui lòng nhập số để đọc.");
                txtNum.Focus();
                return;
            }
            else if (txtnum.Length < 12)
            {
                MessageBox.Show($"Vui lòng nhập số có 12 chữ số.:{txtnum.Length}");
                txtNum.Focus();
                return;
            }
            //Xử lý
            List<string> donvi = new List<string> { "Tỷ", "Triệu", "Nghìn", "" };
            List<string> resultList = CatChuoi(txtnum, 3);

            int hangDonVi = 0;

            foreach (var group in resultList)
            {
                doc += DocHangTram(group);
                if (!string.IsNullOrEmpty(group) && group != "000")
                {
                    doc += " " + donvi[hangDonVi] + " ";
                }
                hangDonVi++;
            }
            txtResult.AppendText($"{doc}.");
        }

        private void txtNum_TextChanged(object sender, EventArgs e) { }
        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRead.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        //
        //Thoát
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn đóng chương trình chứ",
                "Question?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
        //
        //Xoá
        //
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }
    }
}
