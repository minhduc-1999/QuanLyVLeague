using QuanLyGiaiVoDich.DTO_Class.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiVoDich
{
    public partial class KhoiTaoMuaGiai : Form
    {

        public KhoiTaoMuaGiai()
        {
            InitializeComponent();      
        }

        private string maMuaGiai;
        private void KhoiTaoMuaGiaiButton_Click(object sender, EventArgs e)
        {
            //call data access
            try
            {
                Database.MuaGiai_DAO.createMuaGiai(tenMuaGiaTextBox.Text);
                string new_MaMuaGiai = Database.MuaGiai_DAO.queryMaMuaGiai(tenMuaGiaTextBox.Text, 0);
                DIEUKIEN dk = new DIEUKIEN()
                {
                    MaMuaGiai = new_MaMuaGiai,
                    SoCauThuToiThieu = 11,
                    SoCauThuToiDa = 40,
                    TuoiToiDa = 40,
                    TuoiToiThieu = 18,
                    SoLanThayNguoiToiDa = 3,
                    SoCauThuNuocNgoaiToiDa = 3,
                    DiemSoHoa = 1,
                    DiemSoThang = 3,
                    DiemSoThua = 0
                };
                Database.DieuKien_DAO.createDIEUKIEN(dk);
                Database.ThuTuUuTien_DAO.createThuTuUuTien(1, new_MaMuaGiai, "Điểm");
                Database.ThuTuUuTien_DAO.createThuTuUuTien(2, new_MaMuaGiai, "Hiệu Số");
                Database.ThuTuUuTien_DAO.createThuTuUuTien(3, new_MaMuaGiai, "Số Bàn Sân Khách");
                Database.ThuTuUuTien_DAO.createThuTuUuTien(4, new_MaMuaGiai, "Kết Quả Đối Đầu");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }

            // Kiểm tra điền đầy đủ thông tin chưa? Nếu đầy đủ thì sẽ tiến thẳng tới màn hình 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FirstScreen form = new FirstScreen();
                this.Hide();
                form.ShowDialog();
            }
        }

        private void TenMuaGiaTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra textBox đã được điền thông tin vào hay chưa? 
            if (String.IsNullOrEmpty(tenMuaGiaTextBox.Text))
            {
                e.Cancel = true;
                tenMuaGiaTextBox.Focus();
                errorProvider.SetIconAlignment(tenMuaGiaTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(tenMuaGiaTextBox, "Hãy điền đầy đủ thông tin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tenMuaGiaTextBox, null);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FirstScreen form = new FirstScreen();
            form.ShowDialog();
        }

        private void TenMuaGiaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KhoiTaoMuaGiaiButton_Click(this, new EventArgs());
            }
        }

        private void KhoiTaoMuaGiai_FormClosed(object sender, FormClosedEventArgs e)
        {
            FirstScreen form = new FirstScreen();
            this.Hide();
            form.ShowDialog();
        }
    }
}
