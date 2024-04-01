using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        private List<string> danhSach = new List<string>();
        private Random random = new Random();
        public Bai6()
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
