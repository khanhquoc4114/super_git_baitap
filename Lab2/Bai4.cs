using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            txtName.Focus();
        }
        private void Bai4_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        class SinhVien
        {
            public string hoten { get; set; }
            public string mssv { get; set; }
            public string sdt { get; set; }
            public float diem1 { get; set; }
            public float diem2 { get; set; }
            public float diem3 { get; set; }
            public float diemtb { get; set; }

            public SinhVien() { 
                hoten = string.Empty;
                mssv = string.Empty;
                sdt = string.Empty;
                diem1 = 0.0f;
                diem2 = 0.0f;
                diem3 = 0.0f;
                diemtb = 0.0f;
            }
            public SinhVien(string _hoten, string _mssv, string _sdt, float _diem1, float _diem2, float _diem3) { 
                hoten = _hoten;
                mssv = _mssv;
                sdt = _sdt;
                diem1 = _diem1;
                diem2 = _diem2;
                diem3 = _diem3;
            }

            public string thongtin()
            {
                string thongtin = hoten + ";" +
                                 mssv + ";" +
                                 sdt + ";" +
                                 diem1.ToString() + ";" +
                                 diem2.ToString() + ";" +
                                 diem3.ToString() + ";";
                return thongtin;
            }
            public void SetAvg()
            {
                this.diemtb = (diem1 + diem2 + diem3) / 3;
            }
        }

        List<string> thongtin = new List<string>();
        List<SinhVien> dsSinhVien = new List<SinhVien>(); 

        void themdanhsach()
        {
            thongtin.Add(txtName.Text);
            thongtin.Add(txtMSSV.Text);
            thongtin.Add(txtPhone.Text);
            thongtin.Add(txtCourse1.Text);
            thongtin.Add(txtCourse2.Text);
            thongtin.Add(txtCourse3.Text);
        }
        //
        // Button để lưu text thành txt
        //
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                using (StreamWriter streamWriter = new StreamWriter(txtPath.Text))
                {
                    streamWriter.Write(rtbInfo.Text);
                }
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = "test_bai4.txt";
                    saveFileDialog.Filter = "Text file|*.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        txtPath.Text = filePath;

                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.Write(rtbInfo.Text);
                            }
                        }
                    }
                }
            }
            dsSinhVien.Clear();
        }
        //
        // Kiểm tra tính đúng của dữ liệu được đưa vào
        //
        public bool HasEmptyTextbox(System.Windows.Forms.GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox textBox)
                {
                    if(textBox.Enabled == true)
                    if (string.IsNullOrEmpty(textBox.Text.Trim()))
                    {
                        textBox.Focus();
                        return true;
                    }
                }
            }

            return false;
        }
        private bool IsValidInfo()
        {
            if (HasEmptyTextbox(gbInput))
            {
                MessageBox.Show("Có 1 thông tin bị sót");
                return false;
            }
            if (!IsPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            bool isNum1 = isInRange(txtCourse1.Text);
            bool isNum2 = isInRange(txtCourse2.Text);
            bool isNum3 = isInRange(txtCourse3.Text);
            if (!(isNum1 && isNum2 && isNum3))
            {
                MessageBox.Show("Điểm không phù hợp");
                return false;
            }
            return true;
        }
        //
        // Hàm kiểm tra số float và nằm trong khoảng (0,10)
        //
        private bool isInRange(string strDiem)
        {
            if (!float.TryParse(strDiem, out float diem))
            {
                return false;
            }
            if (diem < 0 || diem > 10)
            {
                return false;
            }
            return true;
        }
        //
        // Hàm kiểm tra số điện thoại
        //
        static bool IsPhoneNumber(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
            // Bắt đầu từ chữ số 0, theo sau bởi 9 chữ số khác
            // Tổng cộng 10 chữ số
            Regex phoneNumberRegex = new Regex(@"^0\d{9}$");
            return phoneNumberRegex.IsMatch(input);
        }
        //
        // Button Add thông tin sinh viên
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidInfo())
            {
                return;
            }
            foreach (Control control in gbInput.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if(textBox.Enabled == true)
                        rtbInfo.Text += textBox.Text + ";";
                }
            }
            rtbInfo.Text += Environment.NewLine;
            Clear_textbox(gbInput);
        }

        private void Clear_textbox(System.Windows.Forms.GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }
        //
        // Xử lý phần bên phải
        //
        //
        // Tạo 1 sinh viên
        //
        SinhVien LayThongTin1SinhVien(string info)
        {
            try
            {
                string[] dsInfo = info.Split(';');
                dsInfo = Array.ConvertAll(dsInfo, s => s.Trim());

                float diem1, diem2, diem3;
                if (!float.TryParse(dsInfo[3], out diem1) ||
                    !float.TryParse(dsInfo[4], out diem2) ||
                    !float.TryParse(dsInfo[5], out diem3))
                {
                    MessageBox.Show("Sai số");
                    return null;
                }
                return new SinhVien(dsInfo[0], dsInfo[1], dsInfo[2], diem1, diem2, diem3);
            }
            catch
            {
                return null;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dsSinhVien.Clear();
            Clear_textbox(gbOutput);
            if (txtPath.Text == "")
            {
                btnOpen.PerformClick();
            }
            try
            {
                using (StreamReader streamReader = new StreamReader(txtPath.Text))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        SinhVien sv = LayThongTin1SinhVien(line);
                        if (sv != null)
                        {
                            sv.SetAvg();
                            dsSinhVien.Add(sv);
                        } 
                        else
                        {
                            MessageBox.Show("File nhập không đúng định dạng");
                            return;
                        }
                    }
                    if (dsSinhVien.Count() == 0)
                    {
                        MessageBox.Show("Danh sách trống!");
                        lbNum.Text = "0";
                        return;
                    }
                }
                MessageBox.Show("Đọc được số sinh viên: " + dsSinhVien.Count().ToString());
            }
            catch
            {
                MessageBox.Show("Error reading file!");
                return;
            }
            int num = int.Parse(lbNum.Text);
            Show_Info(0);
            if (dsSinhVien.Count() > 1)
            {
                btnNext.Enabled = true;
            } else
            {
                btnNext.Enabled = false; 
            }
        }

        private void Show_Info(int stt)
        {
            SinhVien sv = dsSinhVien[stt];
            txtNameOut.Text = sv.hoten;
            txtMSSVOut.Text = sv.mssv;
            txtPhoneOut.Text = sv.sdt;
            txtCourse1Out.Text = sv.diem1.ToString();
            txtCourse2Out.Text = sv.diem2.ToString();
            txtCourse3Out.Text = sv.diem3.ToString();
            txtAvgOut.Text = sv.diemtb.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtPath.Text = filePath;

                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    rtbInfo.Text = streamReader.ReadToEnd();
                }
            }
            dsSinhVien.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lbNum.Text);
            num += 1;
            Show_Info(num-1);
            if(num == dsSinhVien.Count())
            {
                btnNext.Enabled = false;
                btnBack.Focus();
            }
            lbNum.Text = (num).ToString();
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lbNum.Text);
            if (num > 1)
            {
                num--;
                Show_Info(num - 1);
                btnNext.Enabled = true;
            }
            if (num == 1)
            {
                btnBack.Enabled = false;
                btnNext.Focus();
            }
            lbNum.Text = num.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Clear_textbox(gbInput);
            txtPath.Clear();
            rtbInfo.Clear();
        }
    }
}
