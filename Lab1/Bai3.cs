using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Lấy text từ textbox tính số nguyên và kiểm tra kiểu dữ liệu
            string txtnum = txtNum.Text.Trim();
            if ((!int.TryParse(txtnum, out int result) && txtnum != "") || (result<0 || result > 9))
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.SelectAll();
                txtNum.Focus();
                return;
            }
            else if (txtnum == "")
            {
                MessageBox.Show("Vui lòng nhập số để đọc.");
                txtNum.Focus();
                return;
            }
            // Tạo mảng numbers để đọc 
            List<string> numbers = new List<string> {"Không","Một","Hai","Ba","Bốn","Năm","Sáu","Bảy","Tám","Chín"};
            txtResult.Text = numbers[result];
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {}

        private void Bai3_Load(object sender, EventArgs e)
        {}

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

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }
    }
}
