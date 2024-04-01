using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Pipes;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
                txtFileName.Text = openFileDialog.SafeFileName.ToString();
                // Tạo các tham số tính 
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;
                try
                {
                    using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        richTbMain.Text = "";
                        // Vòng lặp while xử lý từng hàng trong file
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            lineCount++;
                            wordCount += line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                            charCount += CountCharacters(line);
                            richTbMain.Text += line + Environment.NewLine;
                        }

                        txtLineCount.Text = lineCount.ToString();
                        long fileSize = fileStream.Length;
                        txtSize.Text = fileSize.ToString() + " bytes";
                        txtWordCount.Text = wordCount.ToString();
                        txtCharacterCount.Text = charCount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int CountCharacters(string text)
        {
            return text.Replace(" ", "").Length;
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
