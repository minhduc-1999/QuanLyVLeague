using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiVoDich
{
    public partial class Home : Form
    {
        private bool isTeamListUpdated = false;
        private bool surpressStatusChangePrompt = false;

        public Home()
        {
            InitializeComponent();
            trangThaiComboBox.MouseWheel += new MouseEventHandler(comboBox_MouseWheel_disable);
        }

        private void BangXepHangToolTrip_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FirstScreen form = new FirstScreen();
            this.Hide();
            form.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void TiepNhanHoSoButton_Click(object sender, EventArgs e)
        {
            isTeamListUpdated = true;
            TiepNhanHoSo form = new TiepNhanHoSo();
            form.ShowDialog();
        }

        private void LapLichThiDauButton_Click(object sender, EventArgs e)
        {
            LapLichThiDau form = new LapLichThiDau();
            form.ShowDialog();
        }

        private void ThayDoiQuyDinhButton_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh form = new ThayDoiQuyDinh();
            form.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            ThemSanThiDau form = new ThemSanThiDau();
            form.ShowDialog();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            KetQuaTranDau form = new KetQuaTranDau();
            form.ShowDialog();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            KhoiTaoVongDau form = new KhoiTaoVongDau();
            form.ShowDialog();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            FirstScreen form = new FirstScreen();
            this.Hide();
            form.ShowDialog();
        }

        private void BangXepHangButton_Click(object sender, EventArgs e)
        {
            BangXepHang form = new BangXepHang();
            form.ShowDialog();
        }

        private void DanhSachGhiBanButton_Click(object sender, EventArgs e)
        {
            DanhSachGhiBan form = new DanhSachGhiBan();
            form.ShowDialog();
        }

        private void LapKetQuaTranDauButton_Click(object sender, EventArgs e)
        {
            KetQuaTranDau form = new KetQuaTranDau();
            form.ShowDialog();
        }

        private void TaoVongThiDauButton_Click(object sender, EventArgs e)
        {
            KhoiTaoVongDau form = new KhoiTaoVongDau();
            form.ShowDialog();
        }

        private void ThemSanThiDauButton_Click(object sender, EventArgs e)
        {
            ThemSanThiDau form = new ThemSanThiDau();
            form.ShowDialog();
        }

        private void TiepNhanHoSoButton_Click_1(object sender, EventArgs e)
        {
            isTeamListUpdated = true;
            TiepNhanHoSo form = new TiepNhanHoSo();
            form.ShowDialog();
        }

        private void ThemSanThiDauButton_Click_1(object sender, EventArgs e)
        {
            ThemSanThiDau form = new ThemSanThiDau();
            form.ShowDialog();
        }

        private void TaoVongThiDauButton_Click_1(object sender, EventArgs e)
        {
            KhoiTaoVongDau form = new KhoiTaoVongDau();
            form.ShowDialog();
        }

        private void LapLichThiDauButton_Click_1(object sender, EventArgs e)
        {
            LapLichThiDau form = new LapLichThiDau();
            form.ShowDialog();
        }

        private void LapKetQuaTranDauButton_Click_1(object sender, EventArgs e)
        {
            KetQuaTranDau form = new KetQuaTranDau();
            form.TieuDe = "LẬP KẾT QUẢ TRẬN ĐẤU";
            form.ShowDialog();
        }

        private void ThayDoiQuyDinhButton_Click_1(object sender, EventArgs e)
        {
            ThayDoiQuyDinh form = new ThayDoiQuyDinh();
            form.ShowDialog();
        }

        string maMuaGiai, tenMuaGiai;
        int trangThaiMuaGiai;

        private void Home_Load(object sender, EventArgs e)
        {
            //Load all the data
            this.ketQuaTranDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.KetQuaTranDauExt);
            this.cauThuExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.CauThuExt);
            this.vongDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDauAllowNull);
            this.loaiCauThuAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiCauThuAllowNull);
            this.sanThiDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauAllowNull);
            this.doiBongAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DoiBongAllowNull);
            this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);
            this.sanThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauExt);
            this.lichThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LichThiDauExt);

            //Set filter to all of this to only display record for selected season
            this.cauThuExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' AND MaDoi = '0'";
            this.cauThuExtBindingSource1.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.doiBongAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaDoi = '0'";
            this.doiBongAllowNullBindingSource1.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaDoi = '0'";
            this.doiBongAllowNullBindingSource2.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaDoi = '0'";
            this.doiBongAllowNullBindingSource3.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaDoi = '0'";
            this.doiBongAllowNullBindingSource4.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaDoi = '0'";
            this.doiBongAllowNullBindingSource5.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaDoi = '0'";
            this.ketQuaTranDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' AND SoBanThangDoiNha IS NOT NULL";
            this.vongDauAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaVongDau = '0'";
            this.vongDauAllowNullBindingSource1.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaVongDau = '0'";
            this.vongDauBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.vongDauBindingSource1.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.lichThiDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.sanThiDauAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaSanThiDau = '0'";
            this.sanThiDauAllowNullBindingSource1.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaSanThiDau = '0'";
            this.sanThiDauAllowNullBindingSource2.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaSanThiDau = '0'";
            this.sanThiDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.loaiCauThuAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaLoaiCauThu = '0'";

            // get seasonID
            maMuaGiai = GlobalState.selectedSeasonId;
            Database.MuaGiai_DAO.selectMuaGiai(maMuaGiai, out tenMuaGiai, out trangThaiMuaGiai);

            surpressStatusChangePrompt = true;
            trangThaiComboBox.SelectedIndex = trangThaiMuaGiai;

            // change seasonName
            tenMuaGiaiThongTinLabel.Text = tenMuaGiai;
        }

        private void suaDanhSachCauThuDoiBong_Click(object sender, EventArgs e)
        {
            if (traCuuTenDoiComboBox.SelectedValue == null) return;
            if (traCuuTenDoiComboBox.SelectedValue.ToString().Equals("0"))
            {
                MessageBox.Show("Xin hãy chọn 1 đội trong bảng chọn để chỉnh sửa");
                return;
            }
            TiepNhanHoSo form = new TiepNhanHoSo(traCuuTenDoiComboBox.SelectedValue.ToString());
            form.ShowDialog();
        }

        private void suaDanhSachCauThuGhiBan_Click(object sender, EventArgs e)
        {
            if (danhSachCauThuGhiBanData.SelectedCells.Count == 0 || danhSachCauThuGhiBanData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn 1 cầu thủ trong bảng để chỉnh sửa", "Thông báo");
                return;
            }
            ChinhSuaCauThu form = new ChinhSuaCauThu(danhSachCauThuGhiBanData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void suaDanhSachVongDau_Click(object sender, EventArgs e )
        {
            if (danhSachVongDauData.SelectedCells.Count == 0 || danhSachVongDauData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn 1 vòng đấu trong bảng để chỉnh sửa", "Thông báo");
                return;
            } 
            ChinhSuaVongDau form = new ChinhSuaVongDau(danhSachVongDauData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void suaLichThiDau_Click(object sender, EventArgs e)
        {
            if (danhSachThiDauData.SelectedCells.Count == 0 || danhSachThiDauData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn lịch thi đấu của 1 trận trong bảng để chỉnh sửa", "Thông báo");
                return;
            }
            ChinhSuaLichThiDau form = new ChinhSuaLichThiDau(danhSachThiDauData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void suaThongTinSanThiDau_Click(object sender, EventArgs e)
        {
            if (danhSachSanThiDauData.SelectedCells.Count == 0 || danhSachSanThiDauData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn 1 sân thi đấu trong bảng để chỉnh sửa", "Thông báo");
                return;
            }
            ChinhSuaSanThiDau form = new ChinhSuaSanThiDau(danhSachSanThiDauData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void chiTietTranDau_Click(object sender, EventArgs e)
        {
            if (danhSachTranDauData.SelectedCells.Count == 0 || danhSachTranDauData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn lịch thi đấu của 1 trận trong bảng để xem chi tiết", "Thông báo");
                return;
            }
            ChiTietTranDau form = new ChiTietTranDau(danhSachTranDauData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void suaDanhSachThiDauButton_Click(object sender, EventArgs e)
        {
            if (danhSachTranDauData.SelectedCells.Count == 0 || danhSachTranDauData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn lịch thi đấu của 1 trận trong bảng để xem chi tiết", "Thông báo");
                return;
            }
            GlobalState.selectedMatchId = danhSachTranDauData.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            KetQuaTranDau form = new KetQuaTranDau();
            form.TieuDe = "CHỈNH SỬA KẾT QUẢ";
            form.ShowDialog();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            //TODO: update data view when this form is refocus
            this.ketQuaTranDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.KetQuaTranDauExt);
            this.cauThuExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.CauThuExt);
            this.vongDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDauAllowNull);
            this.loaiCauThuAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiCauThuAllowNull);
            this.sanThiDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauAllowNull);
            if (this.isTeamListUpdated)
            {
                this.doiBongAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DoiBongAllowNull);
                this.isTeamListUpdated = false;
            }
            this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);
            this.sanThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauExt);
            this.lichThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LichThiDauExt);

            List<string> Top3Team = Database.BangXepHang_DAO.getTop3(GlobalState.selectedSeasonId);
            List<string> Top3Player = Database.CauThu_DAO.getTop3(GlobalState.selectedSeasonId);

            label14.Text = Top3Team[0];
            label36.Text = Top3Team[1];
            label37.Text = Top3Team[2];

            label43.Text = Top3Player[0];
            label39.Text = Top3Player[1];
            label38.Text = Top3Player[2];
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.DatabaseManager.Instance.terminateConnection();
        }

        private void traCuuCauThu_Click(object sender, EventArgs e)
        {
            this.cauThuExtBindingSource1.Filter = "(MaMuaGiai = '" + GlobalState.selectedSeasonId + "')";
            if (!maCauThuTextBox.Text.Equals("")) this.cauThuExtBindingSource1.Filter += " AND (MaCauThu LIKE '" + maCauThuTextBox.Text + "*')";
            if (!hoTenTextBox.Text.Equals("")) this.cauThuExtBindingSource1.Filter += " AND (TenCauThu LIKE '" + hoTenTextBox.Text + "*')";
            if (!doiBongComboBox.SelectedValue.Equals("0")) this.cauThuExtBindingSource1.Filter += " AND (MaDoi = '" + doiBongComboBox.SelectedValue.ToString() + "')";
            if (!loaiCauThuComboBox.SelectedValue.Equals("0")) this.cauThuExtBindingSource1.Filter += " AND (MaLoaiCauThu = '" + loaiCauThuComboBox.SelectedValue.ToString() + "')";
            //calculate lower bound and upper bound for birthday
            DateTime minBirthday = DateTime.Now;
            DateTime maxBirthday = DateTime.Now;

            minBirthday = minBirthday.AddYears(-(Int16.Parse(tuoiToiDa.Value.ToString())));
            maxBirthday = maxBirthday.AddYears(-(Int16.Parse(tuoiToiThieu.Value.ToString())));

            this.cauThuExtBindingSource1.Filter += " AND (NgaySinh > #" + minBirthday.ToString("yyyy-MM-dd") + "# AND NgaySinh < #" + maxBirthday.ToString("yyyy-MM-dd") + "#)";
            this.cauThuExtBindingSource1.Filter += " AND (SoBanThang >= " + soBanThang.Value.ToString() + ")";
        }

        private void traCuuDoiBongButton_Click(object sender, EventArgs e)
        {
            this.cauThuExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.sanThiDauAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.cauThuExtBindingSource.Filter += "AND MaDoi = '" + traCuuTenDoiComboBox.SelectedValue.ToString() + "'";
            this.sanThiDauAllowNullBindingSource.Filter += "AND MaDoiNha = '" + traCuuTenDoiComboBox.SelectedValue.ToString() + "'";

            //TODO: load team result and recent match history
            int tranThang, tranHoa, tranThua, hieuSo, banThangSanKhach, diemSo;
            Database.KetQuaDoiBong_DAO.selectKetQuaDoiBong(traCuuTenDoiComboBox.SelectedValue.ToString(), out tranThang, out tranThua, out tranHoa, out hieuSo, out diemSo, out banThangSanKhach);
            ketQuaDiem.Text = diemSo.ToString();
            ketQuaTHT.Text = tranThang.ToString() + " / " + tranHoa.ToString() + " / " + tranThua.ToString();
            ketQuaHieuSo.Text = hieuSo.ToString();
            ketQuaBanSanKhach.Text = banThangSanKhach.ToString();
            maDoiTextBox.Text = traCuuTenDoiComboBox.SelectedValue.ToString();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(Database.TranDau_DAO.load5TranGanNhat(traCuuTenDoiComboBox.SelectedValue.ToString(), GlobalState.selectedSeasonId).ToArray());
        }

        private void ngayThangCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ngayThangCheckBox.Checked)
                ngayThiDauPicker_LichThiDau.Enabled = true;
            else
                ngayThiDauPicker_LichThiDau.Enabled = false;
        }

        private void gioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gioCheckBox.Checked)
                gioThiDauPicker_LichThiDau.Enabled = true;
            else
                gioThiDauPicker_LichThiDau.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                ngayThiDauPicker_KetQuaTranDau.Enabled = true;
            else
                ngayThiDauPicker_KetQuaTranDau.Enabled = false;
        }

        private void traCuuLichThiDau_Click(object sender, EventArgs e)
        {
            this.lichThiDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";

            if (!maLichThiDauTextBox.Text.Equals("")) this.lichThiDauExtBindingSource.Filter += " AND MaTranDau = '" + maLichThiDauTextBox.Text + "'";
            if (!vongDauComboBox_LichThiDau.SelectedValue.ToString().Equals("0")) this.lichThiDauExtBindingSource.Filter += " AND MaVongDau = '" + vongDauComboBox_LichThiDau.SelectedValue.ToString() + "'";
            if (!doiChuNhaComboBox_LichThiDau.SelectedValue.ToString().Equals("0")) this.lichThiDauExtBindingSource.Filter += " AND DoiChuNha = '" + doiChuNhaComboBox_LichThiDau.SelectedValue.ToString() + "'";
            if (!doiKhachComboBox_LichThiDau.SelectedValue.ToString().Equals("0")) this.lichThiDauExtBindingSource.Filter += " AND DoiKhach = '" + doiKhachComboBox_LichThiDau.SelectedValue.ToString() + "'";
            if (!sanThiDauComboBox_LichThiDau.SelectedValue.ToString().Equals("0")) this.lichThiDauExtBindingSource.Filter += " AND MaSanThiDau = '" + sanThiDauComboBox_LichThiDau.SelectedValue.ToString() + "'";
            if (ngayThiDauPicker_LichThiDau.Enabled) this.lichThiDauExtBindingSource.Filter += " AND (NgayThiDau = #" + ngayThiDauPicker_LichThiDau.Value.ToString("yyyy-MM-dd") + "#)";
            //WARNING: Copy and paste code ahead
            TimeSpan oTimeSpan = TimeSpan.Parse(gioThiDauPicker_LichThiDau.Value.ToString("HH:mm:ss"));
            string strTimeSpan =
                string.Format("PT{0}{1}{2}{3}S",
                    (oTimeSpan.Hours == 0
                        ? ""
                        : string.Format("{0:%h}H", oTimeSpan)),
                    (oTimeSpan.Minutes == 0
                        ? ""
                        : string.Format("{0:%m}M", oTimeSpan)),
                    string.Format("{0:%s}", oTimeSpan),
                    string.Format(".{0:fffffff}", oTimeSpan).TrimEnd('0', '.'));
            if (gioThiDauPicker_LichThiDau.Enabled) this.lichThiDauExtBindingSource.Filter += " AND Convert([GioThiDau], '" + typeof(string).ToString() + "')" + "='" + strTimeSpan + "'";
        }

        private void trangThaiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (trangThaiComboBox.SelectedIndex) {
                case 0:
                    thayDoiQuyDinhButton.Enabled = true;
                    tiepNhanHoSoButton.Enabled = false;
                    lapLichThiDauButton.Enabled = false;
                    lapKetQuaTranDauButton.Enabled = false;
                    bangXepHangButton.Enabled = false;
                    danhSachGhiBanButton.Enabled = false;
                    break;
                case 1:
                    thayDoiQuyDinhButton.Enabled = false;
                    tiepNhanHoSoButton.Enabled = true;
                    lapLichThiDauButton.Enabled = true;
                    lapKetQuaTranDauButton.Enabled = false;
                    bangXepHangButton.Enabled = false;
                    danhSachGhiBanButton.Enabled = false;
                    break;
                case 2:
                    thayDoiQuyDinhButton.Enabled = false;
                    tiepNhanHoSoButton.Enabled = false;
                    lapLichThiDauButton.Enabled = true;
                    lapKetQuaTranDauButton.Enabled = true;
                    bangXepHangButton.Enabled = true;
                    danhSachGhiBanButton.Enabled = true;
                    break;
                case 3:
                    thayDoiQuyDinhButton.Enabled = false;
                    tiepNhanHoSoButton.Enabled = false;
                    lapLichThiDauButton.Enabled = false;
                    lapKetQuaTranDauButton.Enabled = false;
                    bangXepHangButton.Enabled = true;
                    danhSachGhiBanButton.Enabled = true;
                    break;
            }
            if (surpressStatusChangePrompt || trangThaiComboBox.SelectedIndex == trangThaiMuaGiai)
            {
                surpressStatusChangePrompt = false;
                return;
            }
            Console.WriteLine("change");
            var result = MessageBox.Show("Bạn có chắc chắn muốn chuyển trạng thái của mùa giải?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                surpressStatusChangePrompt = true;
                trangThaiComboBox.SelectedIndex = trangThaiMuaGiai;
                return;
            }
            else
            {
                try
                {
                    trangThaiMuaGiai = trangThaiComboBox.SelectedIndex;
                    Database.MuaGiai_DAO.updateMuaGiai(GlobalState.selectedSeasonId, tenMuaGiai, trangThaiMuaGiai);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ketQuaTranDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";

            if (!maTranDauTextBox.Text.Equals("")) this.lichThiDauExtBindingSource.Filter += " AND MaTranDau = '" + maTranDauTextBox.Text + "'";
            if (!vongDauComboBox_KetQuanTranDau.SelectedValue.ToString().Equals("0")) this.ketQuaTranDauExtBindingSource.Filter += " AND MaVongDau = '" + vongDauComboBox_KetQuanTranDau.SelectedValue.ToString() + "'";
            if (!doiChuNhaComboBox_KetQuaTranDau.SelectedValue.ToString().Equals("0")) this.ketQuaTranDauExtBindingSource.Filter += " AND DoiChuNha = '" + doiChuNhaComboBox_KetQuaTranDau.SelectedValue.ToString() + "'";
            if (!doiKhachComboBox_KetQuaTranDau.SelectedValue.ToString().Equals("0")) this.ketQuaTranDauExtBindingSource.Filter += " AND DoiKhach = '" + doiKhachComboBox_KetQuaTranDau.SelectedValue.ToString() + "'";
            if (!sanThiDauComboBox_KetQuaTranDau.SelectedValue.ToString().Equals("0")) this.ketQuaTranDauExtBindingSource.Filter += " AND MaSanThiDauChinh = '" + sanThiDauComboBox_KetQuaTranDau.SelectedValue.ToString() + "'";
            if (ngayThiDauPicker_KetQuaTranDau.Enabled) this.ketQuaTranDauExtBindingSource.Filter += " AND (NgayThiDauChinh = #" + ngayThiDauPicker_KetQuaTranDau.Value.ToString("yyyy-MM-dd") + "#)";
        }

        private void xuatDanhSachSanThiDau_Click(object sender, EventArgs e)
        {
            if (danhSachSanThiDauData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể chỉnh sửa nội dung file", "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToCSV(danhSachSanThiDauData, sfd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo");
            }
        }

        private void xuatDanhSachThiDauButton_Click(object sender, EventArgs e)
        {
            if (danhSachTranDauData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể chỉnh sửa nội dung file", "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToCSV(danhSachTranDauData, sfd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo");
            }
        }

        private void xuatDanhSachVongDau_Click(object sender, EventArgs e)
        {
            if (danhSachVongDauData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể chỉnh sửa nội dung file", "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToCSV(danhSachVongDauData, sfd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo");
            }
        }

        private void xuatLichThiDau_Click(object sender, EventArgs e)
        {
            if (danhSachThiDauData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể chỉnh sửa nội dung file", "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToCSV(danhSachThiDauData, sfd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo");
            }
        }

        private void xuatDanhSachCauThuGhiBan_Click(object sender, EventArgs e)
        {
            if (danhSachCauThuGhiBanData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể chỉnh sửa nội dung file", "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToCSV(danhSachCauThuGhiBanData, sfd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo");
            }
        }

        private void xuatDanhSachCauThuDoiBong_Click(object sender, EventArgs e)
        {
            if (danhSachCauThuDoiBongData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể chỉnh sửa nội dung file", "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToCSV(danhSachCauThuDoiBongData, sfd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo");
            }
        }

        private void HDHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_Home form = new HuongDan_Home();
            form.ShowDialog();
        }

        private void HDTiepNhanHoSoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_TiepNhanHoSo form = new HuongDan_TiepNhanHoSo();
            form.ShowDialog();
        }

        private void HDThemSanThiDauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_ThemSanThiDau form = new HuongDan_ThemSanThiDau();
            form.ShowDialog();
        }

        private void HDTaoVongDauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_KhoiTaoVongDau form = new HuongDan_KhoiTaoVongDau();
            form.ShowDialog();
        }

        private void HDLapLichThiDauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_LapLichThiDau form = new HuongDan_LapLichThiDau();
            form.ShowDialog();
        }

        private void HDLapKetQuaTranDauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_KetQuaTranDau form = new HuongDan_KetQuaTranDau();
            form.ShowDialog();
        }

        private void HDTraCuuCauThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_TraCuuCauThu form = new HuongDan_TraCuuCauThu();
            form.ShowDialog();
        }

        private void HDTraCuuDoiBongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_TraCuuDoiBong form = new HuongDan_TraCuuDoiBong();
            form.ShowDialog();
        }

        private void HDTraCuuTranDauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_TraCuuKetQuaThiDau form = new HuongDan_TraCuuKetQuaThiDau();
            form.ShowDialog();
        }

        private void HDTraCuuLichThiDauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_TraCuuLichThiDau form = new HuongDan_TraCuuLichThiDau();
            form.ShowDialog();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HDCacGiaiDoanMuaGiaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan_CacGiaiDoanMuaGiai form = new HuongDan_CacGiaiDoanMuaGiai();
            form.ShowDialog();
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch(tabControl1.SelectedIndex)
                {
                    case 1:
                        traCuuDoiBongButton_Click(this, new EventArgs());
                        break;

                    case 2:
                        traCuuCauThu_Click(this, new EventArgs());
                        break;

                    case 4:
                        traCuuLichThiDau_Click(this, new EventArgs());
                        break;

                    case 5:
                        button2_Click(this, new EventArgs());
                        break;

                    default:
                        break;
                }
            }
        }

        private void thongtinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đồ án Nhập môn Công nghệ Phần mềm\n" +
                "- Trương Bá Cường - 18520013\n" +
                "- Nguyễn Ngọc Đăng - 18520557\n" +
                "- Hà Nhật Linh - 18520086\n" +
                "- Nguyễn Thành Long - 18520092\n" +
                "- Hà Minh Hiệu - 18520736\n" +
                "Giáo viên hướng dẫn: Đỗ Thị Thanh Tuyền\n" +
                "Tháng 7 Năm 2020", "Thông tin nhà phát triển");
        }

        void comboBox_MouseWheel_disable(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
}
