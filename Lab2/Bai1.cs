using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        //
        // Mở hộp thoại chọn file để đọc nội dung
        //
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt"; // Lọc chỉ hiện thị file text (.txt)
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtPath.Text = filePath;

                //Tạo FileStream để mở file ở chế độ đọc
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                // Tạo StreamReader để đọc file từ FileStream
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    rtbMain.Text = streamReader.ReadToEnd();
                }
            }
        }
        //
        // Mở hộp thoại lưu file mới
        //
        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text file|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    txtPath.Text = filePath;
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Append)) // Mở file ở chế độ Append
                    {
                        using (StreamWriter streamWriter = new StreamWriter(fileStream))
                        {
                            streamWriter.Write(rtbMain.Text);
                        }
                    }
                }
            }
        }
        //
        // Mở hộp thoại lưu file đang chỉnh sửa, không có file mới thì tạo file mới
        //
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                using (StreamWriter streamWriter = new StreamWriter(txtPath.Text))
                {
                    streamWriter.Write(rtbMain.Text);
                }
            }
            else
            {
                btnWrite.PerformClick();
            }
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
