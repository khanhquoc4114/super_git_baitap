using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Lấy text từ textbox tính số nguyên
            string txtnum1, txtnum2, txtnum3;
            int num1, num2, num3;
            txtnum1 = txtNum1.Text.Trim();
            txtnum2 = txtNum2.Text.Trim();
            txtnum3 = txtNum3.Text.Trim();
            bool isNum1 = Int32.TryParse(txtnum1, out num1);
            bool isNum2 = Int32.TryParse(txtnum2, out num2);
            bool isNum3 = Int32.TryParse(txtnum3, out num3);
            //Check xem user có nhập đúng số nguyên không
            if (!(isNum1 && isNum2 && isNum3))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Một vài cách xử lý khi nhập sai kiểu dữ liệu
                if (!isNum3)
                {
                    txtNum3.Clear();
                    txtNum3.Focus();
                }
                if (!isNum2)
                {
                    txtNum2.Clear();
                    txtNum2.Focus();
                }
                if (!isNum1)
                {
                    txtNum1.Clear();
                    txtNum1.Focus();
                }
                return;
            }
            // So sánh 3 số
            int max = Math.Max(Math.Max(num1, num2), num3);
            int min = Math.Min(Math.Min(num1, num2), num3);
            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtMax.Clear();
            txtMin.Clear();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
