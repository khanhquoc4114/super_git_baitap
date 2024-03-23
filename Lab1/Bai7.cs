using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            txtInput.KeyDown += txtInput_KeyDown;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            btnDel.PerformClick();
            //Tạo 2 danh sách môn học và xếp loại để dễ quản lý
            List<string> monhoc = new List<string> {"", "Toán", "Lý", "Hoá", "Anh", "Văn" };
            List<string> xeploai = new List<string> {"Giỏi", "Khá", "TB", "Yếu", "Kém"};
            //Tách chuỗi thành các thành phần đơn lẻ
            string input = txtInput.Text.Trim();
            string[] danhsach = input.Split(',');
            danhsach = Array.ConvertAll(danhsach, s => s.Trim());
            //Check logic của chuỗi
            bool isLegit = true;
            //Kiểm tra số lượng đúng của danh sách có bằng 6 thành phần?
            if (danhsach.Length != 6)
            {
                MessageBox.Show("Vui lòng nhập theo cấu trúc: Tên, điếm toán, lý, hoá, anh, văn.");
                return;
            }
            //Kiểm tra xem các phần tử phía sau có phải là integer hay trong thang điểm [0,10]
            for (int i = 1; i < danhsach.Length; i++) 
            {
                double number;
                if (!double.TryParse(danhsach[i], out number) || (number < 0 || number > 10))
                {
                    isLegit = false;
                    break;
                }
            }
            if (isLegit == false)
            {
                MessageBox.Show("Vui lòng nhập theo cấu trúc: Tên, điếm toán, lý, hoá, anh, văn.");
                txtInput.SelectAll();
                txtInput.Focus();
                return;
            }
            //Tạo mảng int chứa số điểm từ mảng string
            float[] diem = new float[danhsach.Length-1];
            for (int i = 1; i < danhsach.Length; i++)
            {
                diem[i-1] = float.Parse(danhsach[i]);
            }
            //Gán text cho textbox
            txtHoten.Text = danhsach[0];
            txtToan.Text = danhsach[1];
            txtLy.Text = danhsach[2];
            txtHoa.Text =  danhsach[3];
            txtAnh.Text = danhsach[4];
            txtVan.Text = danhsach[5];
            //Xử lý
            float diemtong = 0;
            float diem_cao = 0;
            float diem_thap = 10;
            float dem_Dau = 0;
            float dem_Rot = 0;
            float diemTB = 0;
            //Tính điểm trung bình và đếm số lượng môn rớt và môn đậu
            for(int i = 1; i < diem.Length; i++)
            {
                diemtong += diem[i];
                if (diem[i] > diem_cao) diem_cao = diem[i];
                if (diem[i] < diem_thap) diem_thap = diem[i];
                if (diem[i] < 5) dem_Rot++; else dem_Dau++;
            }
            diemTB = diemtong / (diem.Length - 1);
            txtTB.Text = (diemTB).ToString();
            txtDau.Text = dem_Dau.ToString();
            txtRot.Text = dem_Rot.ToString();
            //Tìm môn học có điểm thấp nhất và cao nhất
            for (int i = 1; i < diem.Length ; i++)
            {
                if (diem[i]==diem_cao) {
                    txtCao.AppendText($"{monhoc[i]} ");
                }
                if (diem[i] == diem_thap)
                {
                    txtThap.AppendText($"{monhoc[i]} ");
                }
            }
            //Phân xếp loại sinh viên
            int index_Loai = 0;
            if (diemTB >= 8.5)
                index_Loai = CheckXepLoai(diem, 6.5, 1);
            else if (diemTB >= 6.5)
                index_Loai = CheckXepLoai(diem, 5, 2);
            else if (diemTB >= 5)
                index_Loai = CheckXepLoai(diem, 3.5, 3);
            else if (diemTB >= 3.5)
                index_Loai = CheckXepLoai(diem, 2, 4);
            else
            {
                index_Loai = 4;
            }
            txtXepLoai.Text += xeploai[index_Loai];
        }

        private int CheckXepLoai(float[] diem, double diemDK, int index_Loai)
        {
            for (int i = 0; i < diem.Length; i++)
            {
                if (diem[i] < diemDK)
                    return index_Loai + 1;
            }
            return index_Loai;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox && control != txtInput)
                {
                    ((TextBox)control).Clear();
                }
            }
            txtInput.Focus();
            txtInput.SelectAll();
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
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRun.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
