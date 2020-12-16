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
    public partial class ChinhSuaLichThiDau : Form
    {
        private string selectedMatchId;
        private bool surpressDiscardPrompt = false;

        public ChinhSuaLichThiDau(string v)
        {
            selectedMatchId = v;
            InitializeComponent();
        }

        private void ChinhSuaLichThiDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.VongDau' table. You can move, or remove it, as needed.
            this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.SanThiDau' table. You can move, or remove it, as needed.
            this.sanThiDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDau);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.DoiBong' table. You can move, or remove it, as needed.
            this.doiBongTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DoiBong);

            muaGiaiComboBox.SelectedValue = GlobalState.selectedSeasonId;
            sanThiDauBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            doiBongBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            doiBongBindingSource1.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";

            string doiNha, doiKhach, sanThiDau, vongDau;
            DateTime ngayThiDau, gioThiDau;
            try
            {
                DAO_QLBongDa.Database.TranDau_DAO.loadThongTinThiDau(selectedMatchId, out doiNha, out doiKhach, out ngayThiDau, out gioThiDau, out sanThiDau, out vongDau);
                vongThiDauComboBox.SelectedValue = vongDau;
                doChuNhaComboBox.SelectedValue = doiNha;
                doiKhachComboBox.SelectedValue = doiKhach;
                ngayThiDauPicker.Value = ngayThiDau;
                gioThiDauPicker.Value = gioThiDau;
                sanThiDauComboBox.SelectedValue = sanThiDau;

                doiChuNhaLabel.Text = doChuNhaComboBox.Text;
                doiKhachLabel.Text = doiKhachComboBox.Text;
                ngayThiDauLabel.Text = ngayThiDau.ToString("yyyy/MM/dd");
                gioThiDauLabel.Text = gioThiDau.ToString("HH:mm:ss");
                sanThiDauLabel.Text = sanThiDauComboBox.Text;
                muaGiaiLabel.Text = muaGiaiComboBox.Text;
                vongThiDauLabel.Text = vongThiDauComboBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }

        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: check if the match can be edited
                DAO_QLBongDa.Database.TranDau_DAO.updateLichThiDau(selectedMatchId, ngayThiDauPicker.Value, gioThiDauPicker.Value, sanThiDauComboBox.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công", "Thông báo");
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
            if (DAO_QLBongDa.Database.TranDau_DAO.kiemTraTranDauDaDienRa(selectedMatchId))
            {
                MessageBox.Show("Bạn không thể xóa trận đấu đã diễn ra", "Thông báo");
                return;
            } 
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu lịch thi đấu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DAO_QLBongDa.Database.TranDau_DAO.removeTranDau(selectedMatchId);
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

        private void ChinhSuaLichThiDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (surpressDiscardPrompt) return;
            var result = MessageBox.Show("Thay đổi này sẽ không được lưu nếu bạn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ChinhSuaLichThiDau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                capNhatButton_Click(this, new EventArgs());
            }
        }
    }
}
