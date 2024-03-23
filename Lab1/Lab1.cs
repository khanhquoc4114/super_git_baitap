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
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new();
            bai2.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.ShowDialog();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.ShowDialog();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            Bai7 bai7 = new Bai7();
            bai7.ShowDialog();
        }

        private void btnBai8_Click(object sender, EventArgs e)
        {
            Bai8 bai8 = new Bai8();
            bai8.ShowDialog();
        }

        private void btnBai9_Click(object sender, EventArgs e)
        {
            Bai9 bai9 = new Bai9();
            bai9.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn đóng chương trình chứ?",
                "Lab1",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
