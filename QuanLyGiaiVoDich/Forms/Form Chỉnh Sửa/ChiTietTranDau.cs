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
    public partial class ChiTietTranDau : Form
    {
        private string selectedMatchId;
        public ChiTietTranDau(string v)
        {
            InitializeComponent();
            selectedMatchId = v;
        }

        private void chinhSuaKetQuaButton_Click(object sender, EventArgs e)
        {
            GlobalState.selectedMatchId = selectedMatchId;
            KetQuaTranDau form = new KetQuaTranDau();
            form.TieuDe = "CHỈNH SỬA KẾT QUẢ";
            form.ShowDialog();
        }

        private void ChiTietTranDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.SanThiDauAllowNull' table. You can move, or remove it, as needed.
            this.sanThiDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauAllowNull);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.DoiBong' table. You can move, or remove it, as needed.
            this.doiBongTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DoiBong);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.VongDau' table. You can move, or remove it, as needed.
            this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.RaSanExt' table. You can move, or remove it, as needed.
            this.raSanExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanExt);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.ThayNguoiExt' table. You can move, or remove it, as needed.
            this.thayNguoiExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.ThayNguoiExt);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.ThePhatExt' table. You can move, or remove it, as needed.
            this.thePhatExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.ThePhatExt);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.BanThangExt' table. You can move, or remove it, as needed.
            this.banThangExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.BanThangExt);

            reloadMatchInfo();

            thayNguoiExtBindingSource.Filter = "MaTranDau = '" + selectedMatchId + "'";
            thePhatExtBindingSource.Filter = "MaTranDau = '" + selectedMatchId + "'";
            banThangExtBindingSource.Filter = "MaTranDau = '" + selectedMatchId + "'";
            raSanExtBindingSource.Filter = "MaDoi = '" + doiNhaComboBox.SelectedValue + "' AND MaTranDau = '" + selectedMatchId + "'";
            raSanExtBindingSource1.Filter = "MaDoi = '" + doiKhachComboBox.SelectedValue + "' AND MaTranDau = '" + selectedMatchId + "'";
        }

        private void reloadMatchInfo()
        {
            maTranDauTextBox.Text = selectedMatchId;
            //TODO: load match schedule info
            string MaDoiChuNha;
            string MaDoiKhach;
            DateTime ngayThiDau;
            DateTime gioThiDau;
            string MaSanThiDau;
            string MaVongDau;
            DAO_QLBongDa.Database.TranDau_DAO.loadThongTinThiDau(selectedMatchId, out MaDoiChuNha, out MaDoiKhach, out ngayThiDau, out gioThiDau, out MaSanThiDau, out MaVongDau);
            doiNhaComboBox.SelectedValue = MaDoiChuNha;
            doiKhachComboBox.SelectedValue = MaDoiKhach;
            sanThiDauComboBox.SelectedValue = MaSanThiDau;
            gioPicker.Value = gioThiDau;
            ngayPicker.Value = ngayThiDau;

            //TODO: load game score (0-0 if score is null)
            int tiSoNha; int tiSoKhach;
            DAO_QLBongDa.Database.TranDau_DAO.loadTiSoTranDau(selectedMatchId, out tiSoNha, out tiSoKhach);
            tiSoDoiNha.Text = tiSoNha.ToString();
            tiSoDoiKhach.Text = tiSoKhach.ToString();

            //load game time (00:00 if time is null)
            TimeSpan thoiGianThiDau = DAO_QLBongDa.Database.TranDau_DAO.loadThoiGianThiDau(selectedMatchId);
            thoiGianThiDauLabel.Text = string.Format("{0:000}:{1:00}", thoiGianThiDau.Hours * 60 + thoiGianThiDau.Minutes, thoiGianThiDau.Seconds);
        }
    }
}
