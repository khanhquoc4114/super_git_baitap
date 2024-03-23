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
    public partial class Bai8 : Form
    {
        private List<string> danhSach = new List<string>();
        private Random random = new Random();
        public Bai8()
        {
            InitializeComponent();
            txtAddFood.KeyDown += txtAddFood_KeyDown;
            lwFood.View = View.List;
            txtAddFood.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userInput = txtAddFood.Text;
            if (!string.IsNullOrEmpty(userInput))
            {
                danhSach.Add(userInput);
                lwFood.Items.Clear();

                foreach (var item in danhSach)
                {
                    lwFood.Items.Add(item);
                }
                txtAddFood.Clear();
            }
            txtAddFood.Focus();
        }

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (danhSach.Count > 0)
            {
                int randomIndex = random.Next(danhSach.Count);
                if (danhSach[randomIndex] == txtResult.Text)
                {
                    randomIndex = random.Next(danhSach.Count);
                }
                string selectedValue = danhSach[randomIndex];
                txtResult.Text = selectedValue;
            }
            else
            {
                txtResult.Text = "Danh sách trống!";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn chắc muốn xoá hết chứ?",
                "Question?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                lwFood.Clear();
                danhSach.Clear();
                txtResult.Clear();
                txtAddFood.Clear();
                txtAddFood.Focus();
            }

        }
        private void txtAddFood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
