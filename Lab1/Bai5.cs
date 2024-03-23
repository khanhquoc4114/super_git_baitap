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
    public partial class Bai5 : Form
    {
        public object Control { get; private set; }

        public Bai5()
        {
            InitializeComponent();
            cb1.Text = cb1.Items[0].ToString();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private long GiaiThua(int n)
        {
            if (n < 0) {return 0;}
            long ketqua = 1;
            for (int i=1; i <= n; i++)
            {
                ketqua *= i;
            }
            return ketqua;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            //Kiểm tra kiểu dữ liệu 
            string txtnum1 = txtNum1.Text.Trim();
            string txtnum2 = txtNum2.Text.Trim();
            int num1, num2;
            bool isNum1 = Int32.TryParse(txtnum1, out num1);
            bool isNum2 = Int32.TryParse(txtnum2, out num2);
            if(!(isNum1 && isNum2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Một số tuỳ chỉnh giúp nhập dễ dàng hơn
                if(!isNum1 && !isNum2)
                {
                    txtNum1.Clear();
                    txtNum2.Clear();
                    txtNum1.Focus();
                    return;
                }
                if (!isNum2)
                {
                    txtNum2.Clear();
                    txtNum2.Focus();
                    return;
                }
                if (!isNum1)
                {
                    txtNum1.Clear();
                    txtNum1.Focus();
                    return;
                }
            }

            if (txtnum1 == "" || txtnum2=="") {
                MessageBox.Show("Vui lòng nhập số!");
                return;
            }
            //Xử lý đề bài
            int selectedIndex = cb1.SelectedIndex;
            //Bảng cửu chương
            if (selectedIndex == 0)
            {
                // Bảng cứu chương của A và B cho 1 đến 10
                long sum1, sum2;
                for(int i=1; i<= 10; i++)
                {
                    txtResult.Text += $"{num1} * {i} = ";
                    sum1 = num1 * i;
                    txtResult.Text += sum1.ToString();
                    txtResult.Text += $" - {num1} * {i} = ";
                    sum2 = num2 * i;
                    txtResult.Text += sum2.ToString();
                    txtResult.Text += Environment.NewLine; ;
                }
            } else if (selectedIndex == 1) { //tính toán giá trị
                // (A-B)!
                if(num1-num2 < 0)
                {
                    txtResult.AppendText("Số âm không có giai thừa" + Environment.NewLine);
                } else
                {
                    txtResult.Text += $"({num1} - {num2})! = ";
                    long ketqua = GiaiThua(num1 - num2);
                    txtResult.Text += ketqua.ToString() + Environment.NewLine;
                }
                // tổng A mũ từ 1 đến B
                double sum = 0;
                txtResult.Text += "S =";
                if (num2 < 0)
                {
                    txtResult.Text += 0 ;
                    return;
                }
                for (int i=1; i <= num2; i++)
                {
                    txtResult.Text += $"{num1}^{i}";
                    if (i != num2) { txtResult.Text += "+"; }
                    sum += Math.Pow(num1, i);
                }
                txtResult.Text += "=" + sum.ToString() + Environment.NewLine;
            }
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

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cb1.SelectedIndex;
            cb1.Text = cb1.SelectedIndex.ToString();
        }
    }
}
