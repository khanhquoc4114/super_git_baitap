using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Lấy text từ textbox tính số nguyên
            string txtnum1, txtnum2;
            txtnum1 = txtNum1.Text.Trim();
            txtnum2 = txtNum2.Text.Trim();
            bool isNum1 = int.TryParse(txtnum1, out int num1);
            bool isNum2 = int.TryParse(txtnum2, out int num2);
            //Check xem user có nhập đúng số nguyên không
            if (!(isNum1 && isNum2)) {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();
                return;
            }
            // Thực hiện tính tổng và xuất
            long sum;
            sum = num1 + num2;
            txtResult.Text = sum.ToString();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
            txtNum1.Focus();
        }

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
    }
}
