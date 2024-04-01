using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            txtPathOutput.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtPath.Text = filePath;

                // Yêu cầu giải quyết tài nguyên sau khi sử dụng 
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    rtbInput.Text = streamReader.ReadToEnd();
                }
            }
            btnCalc.Enabled = true;
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int dong = 0;
            foreach (var line in rtbInput.Lines){
                dong++;
                try
                {
                    string result = Calc(line);
                    rtbOutput.Text += result + Environment.NewLine;
                } catch
                {
                    MessageBox.Show("Sai dữ liệu phép tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
;                }
            }
            btnSave.Enabled = true;
        }
        private string Calc(string expression)
        {
            DataTable table = new DataTable();
            object result = table.Compute(expression, "");
            return expression + " = " + result.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                string parent = Path.GetDirectoryName(txtPath.Text);
                string output = Path.Combine(parent, "output.txt");

                using (StreamWriter streamWriter = new StreamWriter(output))
                {
                    streamWriter.Write(rtbOutput.Text);
                }

                txtPathOutput.Text = output;
                MessageBox.Show("Tập tin đã được lưu thành công!");
            }
            else
            {
                MessageBox.Show("Đường dẫn không hợp lệ!");
            }
            btnSave.Enabled = false;
        }
    }
}
