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
    public partial class ChinhSuaCauThu : Form
    {
        private string selectedPlayerId;
        private bool surpressDiscardPrompt = false;
        private int tuoiToiThieu;
        private int tuoiToiDa;

        public ChinhSuaCauThu(string v)
        {
            InitializeComponent();
            selectedPlayerId = v;
        }

        private void ChinhSuaCauThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.LoaiCauThu' table. You can move, or remove it, as needed.
            this.loaiCauThuTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiCauThu);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.DoiBong' table. You can move, or remove it, as needed.
            doiBongBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            loaiCauThuBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.doiBongTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DoiBong);
            // Display data from Profile into textBoxes
            string tenCauThu, maLoaiCauThu, ghiChu, maDoi;
            int soAo, soBanThang;
            DateTime ngaySinh;
            DAO_QLBongDa.Database.CauThu_DAO.selectCauThu(selectedPlayerId, out tenCauThu, out ngaySinh, out maLoaiCauThu, out ghiChu, out maDoi, out soBanThang, out soAo);
            ngaySinhPicker.Value = ngaySinh;
            loaiCauThuComboBox.SelectedValue = maLoaiCauThu;
            doiBongComboBox.SelectedValue = maDoi;
            chonSoAo.Value = soAo;
            hoTenTextBox.Text = tenCauThu;
            ghiChuEditBox.Text = ghiChu;
            maCauThuTextBox.Text = selectedPlayerId;
            maCauThuLabel.Text = selectedPlayerId;
            tenCauThuLabel.Text = tenCauThu;
            doiBongLabel.Text = doiBongComboBox.Text;
            ngaySinhLabel.Text = ngaySinhPicker.Value.ToString("dd-MM-yyyy");
            soBanThangLabel.Text = soBanThang.ToString();
            soAoLabel.Text = soAo.ToString();
            loaiCauThuLabel.Text = loaiCauThuComboBox.Text;

            //load constraint
            DAO_QLBongDa.Database.DieuKien_DAO.queryGioiHanTuoi(GlobalState.selectedSeasonId, out tuoiToiThieu, out tuoiToiDa);
        }

        // Calculate age of soccer player
        private int tinhTuoiCauThu(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;

            // Nếu chưa đến sinh nhật thì tuổi - 1
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;

            return age;

        }

        // Validate age 
        private void NgaySinhPicker_Validating(object sender, CancelEventArgs e)
        {
            // tuoiToiDa, tuoiToiThieu should be changed to data from SQL 
            DateTime dateOfBirth = ngaySinhPicker.Value;

            int age = new int();
            age = tinhTuoiCauThu(dateOfBirth);

            // check that age's incorrect 
            if (age > tuoiToiDa || age < tuoiToiThieu)
            {
                e.Cancel = true;
                errorProvider.SetIconAlignment(ngaySinhPicker, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(ngaySinhPicker, "Ngày sinh không phù hợp với điều kiện!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(ngaySinhPicker, null);
            }
        }

        private void CapNhatButton_Click(object sender, EventArgs e)
        {
            // if everything is validated 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // update information for soccer player
                try
                {
                    DAO_QLBongDa.Database.CauThu_DAO.updateCauThu(selectedPlayerId, tenCauThuLabel.Text, ngaySinhPicker.Value, loaiCauThuComboBox.SelectedValue.ToString(), ghiChuEditBox.Text, doiBongComboBox.SelectedValue.ToString(), Int32.Parse(soBanThangLabel.Text), Int16.Parse(chonSoAo.Value.ToString()));
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                    surpressDiscardPrompt = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void HoTenTextBox_Validating(object sender, CancelEventArgs e)
        {
            // if hotenTextBox is null => error 
            if (string.IsNullOrEmpty(hoTenTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetIconAlignment(hoTenTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(hoTenTextBox, "Hãy điền đầy đủ thông tin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(hoTenTextBox, null);
            }
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa cầu thủ này khỏi danh sách của đội bóng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DAO_QLBongDa.Database.CauThu_DAO.updateRoiDoiBong(selectedPlayerId, DateTime.Now);
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    surpressDiscardPrompt = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void ChinhSuaCauThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (surpressDiscardPrompt) return;
            var result = MessageBox.Show("Thay đổi này sẽ không được lưu nếu bạn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ChinhSuaCauThu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CapNhatButton_Click(this, new EventArgs());
            }
        }
    }
}
