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
    public partial class ChinhSuaSanThiDau : Form
    {
        private string selectedStadiumId;
        private bool surpressDiscardPrompt = false;

        public ChinhSuaSanThiDau(string v)
        {
            InitializeComponent();
            selectedStadiumId = v;
        }

        private void ChinhSuaSanThiDau_Load(object sender, EventArgs e)
        {
            string maDoiNha, tenSan, tenDVSoHuu;
            Database.SanThiDau_DAO.selectSanThiDau(selectedStadiumId, out tenSan, out tenDVSoHuu, out maDoiNha);
            tenSanThiDauTextBox.Text = tenSan;
            tenDonViSoHuuTextBox.Text = tenDVSoHuu;
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SanThiDau_DAO.updateSanThiDau(selectedStadiumId, tenSanThiDauTextBox.Text, tenDonViSoHuuTextBox.Text);
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                surpressDiscardPrompt = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu sân thi đấu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Database.SanThiDau_DAO.removeSanThiDau(selectedStadiumId);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    surpressDiscardPrompt = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void ChinhSuaSanThiDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (surpressDiscardPrompt) return;
            var result = MessageBox.Show("Thay đổi này sẽ không được lưu nếu bạn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TenSanThiDauTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TenDonViSoHuuTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ChinhSuaSanThiDau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                capNhatButton_Click(this, new EventArgs());
            }
        }
    }
}
