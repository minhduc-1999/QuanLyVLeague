using QuanLyGiaiVoDich.DTO_Class.Class;
using QuanLyGiaiVoDich.Forms.Form_khai_báo;
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
    public partial class KetQuaTranDau : Form
    {
        public KetQuaTranDau()
        {
            InitializeComponent();
        }

        public string tieuDe;
        private bool isPlayerListUpdate = false;
        private bool isMatchSelectUpdate = false;

        private string selectedGoalId = "";
        private string selectedFoulId = "";
        private string selectedChangeId = "";

        public string TieuDe
        {
            get { return tieuDe; }
            set { tieuDe = value; }
        }

        private void KetQuaTranDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.LoaiThe' table. You can move, or remove it, as needed.
            this.loaiTheTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiThe);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.CauThu' table. You can move, or remove it, as needed.
            this.cauThuTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.CauThu);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.RaSanSelector' table. You can move, or remove it, as needed.
            this.raSanSelectorTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanSelector);
            this.loaiBanThangTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiBanThang);
            this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);
            this.sanThiDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauAllowNull);
            this.doiBongAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DoiBongAllowNull);
            tieuDeForm.Text = TieuDe;
            if (!GlobalState.selectedMatchId.Equals("")) reloadMatchInfo();
			
			vongDauBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            sanThiDauAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
        }

        private void danhSachCauThuDoiChuNhaButton_Click(object sender, EventArgs e)
        {
            isPlayerListUpdate = true;
            DanhSachCauThu form = new DanhSachCauThu(doiNhaComboBox.SelectedValue.ToString());
            form.ShowDialog();
        }

        private void danhSachCauThuDoiKhachButton_Click(object sender, EventArgs e)
        {
            isPlayerListUpdate = true;
            DanhSachCauThu form = new DanhSachCauThu(doiKhachComboBox.SelectedValue.ToString());
            form.ShowDialog();
        }

        private void maTranDauTextBox_Click(object sender, EventArgs e)
        {
            isMatchSelectUpdate = true;
            DanhSachTranDau form = new DanhSachTranDau(vongDauComboBox.SelectedValue.ToString());
            form.Show();
        }

        private void KetQuaTranDau_Activated(object sender, EventArgs e)
        {
            //if return from match selection screen
            if (!isMatchSelectUpdate)
            {
            }
            else if (GlobalState.selectedMatchId.Equals("")) 
            { 
                maTranDauTextBox.Text = "<Chọn trận>";
            }
            else 
            {
                reloadMatchInfo();
            }
            isMatchSelectUpdate = false;

            //if return from player selection screen
            if (isPlayerListUpdate)
                this.raSanExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanExt);
            this.isPlayerListUpdate = false;
        }

        private void reloadMatchInfo()
        {
            maTranDauTextBox.Text = GlobalState.selectedMatchId;
            //TODO: load match schedule info
            string MaDoiChuNha;
            string MaDoiKhach;
            DateTime ngayThiDau;
            DateTime gioThiDau;
            string MaSanThiDau;
            string MaVongDau;
            Database.TranDau_DAO.loadThongTinThiDau(GlobalState.selectedMatchId, out MaDoiChuNha, out MaDoiKhach, out ngayThiDau, out gioThiDau, out MaSanThiDau, out MaVongDau);
            doiNhaComboBox.SelectedValue = MaDoiChuNha;
            doiKhachComboBox.SelectedValue = MaDoiKhach;
            sanThiDauComboBox.SelectedValue = MaSanThiDau;
            gioPicker.Value = gioThiDau;
            ngayPicker.Value = ngayThiDau;

            doiGhiBanComboBox.Items.Clear();
            doiGhiBanComboBox.Text = "";

            doiThayNguoiComboBox.Items.Clear();
            doiThayNguoiComboBox.Text = "";

            doiPhamLoiComboBox.Items.Clear();
            doiPhamLoiComboBox.Text = "";

            cauThuGhiBanComboBox.Enabled = false;
            cauThuPhamLoiComboBox.Enabled = false;
            cauThuRaSanComboBox.Enabled = false;
            cauThuVaoSanComboBox.Enabled = false;

            tenDoiNhaTextBox.Text = doiNhaComboBox.Text;
            tenDoiKhachTextBox.Text = doiKhachComboBox.Text;

            doiGhiBanComboBox.Items.Insert(0, doiNhaComboBox.Text);
            doiGhiBanComboBox.Items.Insert(1, doiKhachComboBox.Text);

            doiThayNguoiComboBox.Items.Insert(0, doiNhaComboBox.Text);
            doiThayNguoiComboBox.Items.Insert(1, doiKhachComboBox.Text);

            doiPhamLoiComboBox.Items.Insert(0, doiNhaComboBox.Text);
            doiPhamLoiComboBox.Items.Insert(1, doiKhachComboBox.Text);

            luuKetQuaButton.Enabled = true;

            //disable all player selection menu
            danhSachThayNguoiData.Enabled = false;
            cauThuGhiBanComboBox.Enabled = false;
            cauThuPhamLoiComboBox.Enabled = false;
            cauThuRaSanComboBox.Enabled = false;
            cauThuVaoSanComboBox.Enabled = false;

            cauThuBindingSource.Filter = "MaDoi = '" + doiNhaComboBox.SelectedValue + "'";
            cauThuBindingSource1.Filter = "MaDoi = '" + doiKhachComboBox.SelectedValue + "'";

            //TODO: load game score (0-0 if score is null)
            int tiSoNha; int tiSoKhach;
            Database.TranDau_DAO.loadTiSoTranDau(GlobalState.selectedMatchId, out tiSoNha, out tiSoKhach);
            tiSoDoiNha.Text = tiSoNha.ToString();
            tiSoDoiKhach.Text = tiSoKhach.ToString();

            //load game time (00:00 if time is null)
            TimeSpan thoiGianThiDau = Database.TranDau_DAO.loadThoiGianThiDau(GlobalState.selectedMatchId);
            phutTranDau.Value = thoiGianThiDau.Hours * 60 + thoiGianThiDau.Minutes;
            giayTranDau.Value = thoiGianThiDau.Seconds;
        }

        private void KetQuaTranDau_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalState.selectedMatchId = "";
        }

        private void doiGhiBanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("change");
            cauThuGhiBanComboBox.Enabled = true;
            string filterId = "";
            if (doiGhiBanComboBox.SelectedIndex == 0) filterId = doiNhaComboBox.SelectedValue.ToString();
            else if (doiGhiBanComboBox.SelectedIndex == 1) filterId = doiKhachComboBox.SelectedValue.ToString();
            //adjust filter
            raSanSelectorBindingSource.Filter = "MaDoi = '" + filterId + "' AND MaTranDau = '" + GlobalState.selectedMatchId + "'";
        }

        private void doiPhamLoiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cauThuPhamLoiComboBox.Enabled = true;
            string filterId = "";
            if (doiPhamLoiComboBox.SelectedIndex == 0) filterId = doiNhaComboBox.SelectedValue.ToString();
            else if (doiPhamLoiComboBox.SelectedIndex == 1) filterId = doiKhachComboBox.SelectedValue.ToString();
            //adjust filter
            raSanSelectorBindingSource1.Filter = "MaDoi = '" + filterId + "' AND MaTranDau = '" + GlobalState.selectedMatchId + "'";
        }



        private void luuKetQuaButton_Click(object sender, EventArgs e)
        {
            //2 mode: input match info and input match detail
            if (luuKetQuaButton.Text.Equals("Nhập Chi Tiết Trận Đấu"))
            {
                //save match info and disable all match info field
                string MaTranDau = GlobalState.selectedMatchId;
                DateTime NgayThiDauChinh = ngayPicker.Value;
                DateTime GioThiDauChinh = gioPicker.Value;
                string MaSanThiDauChinh = sanThiDauComboBox.SelectedValue.ToString();
                TimeSpan ThoiGianThiDau = new TimeSpan(0, Int32.Parse(phutTranDau.Value.ToString()),
                    Int32.Parse(giayTranDau.Value.ToString()));
                int SoBanThangDoiNha = Int32.Parse(tiSoDoiNha.Text);
                int SoBanThangDoiKhach = Int32.Parse(tiSoDoiKhach.Text);
                TRANDAU trandau = new TRANDAU()
                {
                    MaTranDau = GlobalState.selectedMatchId,
                    NgayThiDauChinh = ngayPicker.Value,
                    GioThiDauChinh = gioPicker.Value,
                    MaSanThiDauChinh = sanThiDauComboBox.SelectedValue.ToString(),
                    ThoiGianThiDau = new TimeSpan(0, Int32.Parse(phutTranDau.Value.ToString()), Int32.Parse(giayTranDau.Value.ToString())),
                    SoBanThangDoiNha = Int32.Parse(tiSoDoiNha.Text),
                    SoBanThangDoiKhach = Int32.Parse(tiSoDoiKhach.Text)
                };
                Database.TranDau_DAO.updateTranDau(trandau);
                maTranDauTextBox.Enabled = false;
                ngayPicker.Enabled = false;
                gioPicker.Enabled = false;
                sanThiDauComboBox.Enabled = false;
                phutTranDau.Enabled = false;
                giayTranDau.Enabled = false;
                vongDauComboBox.Enabled = false;

                //enable match detail editing and load existing match detail data
                danhSachThayNguoiData.Enabled = true;
                cauThuDoiNhaComboBox.Enabled = true;
                cauThuDoiKhachComboBox.Enabled = true;

                this.thayNguoiExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.ThayNguoiExt);
                this.raSanExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanExt);
                this.thePhatExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.ThePhatExt);
                this.banThangExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.BanThangExt);

                thayNguoiExtBindingSource.Filter = "MaTranDau = '" + GlobalState.selectedMatchId + "'";
                thePhatExtBindingSource.Filter = "MaTranDau = '" + GlobalState.selectedMatchId + "'";
                banThangExtBindingSource.Filter = "MaTranDau = '" + GlobalState.selectedMatchId + "'";
                raSanExtBindingSource.Filter = "MaDoi = '" + doiNhaComboBox.SelectedValue + "' AND MaTranDau = '" + GlobalState.selectedMatchId + "'";
                raSanExtBindingSource1.Filter = "MaDoi = '" + doiKhachComboBox.SelectedValue + "' AND MaTranDau = '" + GlobalState.selectedMatchId + "'";

                //change button name
                luuKetQuaButton.Text = "Nhập Thông Tin Trận Đấu";
            }
            else if (luuKetQuaButton.Text.Equals("Nhập Thông Tin Trận Đấu"))
            {
                //disable all match detail field
                danhSachThayNguoiData.Enabled = false;
                cauThuDoiNhaComboBox.Enabled = false;
                cauThuDoiNhaComboBox.Enabled = false;

                //enable match info field
                maTranDauTextBox.Enabled = true;
                ngayPicker.Enabled = true;
                gioPicker.Enabled = true;
                sanThiDauComboBox.Enabled = true;
                phutTranDau.Enabled = true;
                giayTranDau.Enabled = true;
                vongDauComboBox.Enabled = true;

                //change button name
                luuKetQuaButton.Text = "Nhập Chi Tiết Trận Đấu";
            }
        }

        private void luuThamGiaDoiNha_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.raSanExtBindingSource.EndEdit();
                this.raSanExtTableAdapter.Update(this.quanLyGiaiVoDichDataSet.RaSanExt);
                MessageBox.Show("Lưu thành công", "Thông Báo");

                //TODO: refill all data binding regarding picking players
                raSanSelectorTableAdapter.Fill(quanLyGiaiVoDichDataSet.RaSanSelector);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }

        private void luuThamGiaDoiKhach_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.raSanExtBindingSource1.EndEdit();
                this.raSanExtTableAdapter.Update(this.quanLyGiaiVoDichDataSet.RaSanExt);
                MessageBox.Show("Lưu thành công", "Thông Báo");

                //TODO: refill all data binding regarding picking players
                raSanSelectorTableAdapter.Fill(quanLyGiaiVoDichDataSet.RaSanSelector);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }

        private void doiThayNguoiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cauThuRaSanComboBox.Enabled = true;
            cauThuVaoSanComboBox.Enabled = true;
            string filterId = "";
            if (doiThayNguoiComboBox.SelectedIndex == 0) filterId = doiNhaComboBox.SelectedValue.ToString();
            else if (doiThayNguoiComboBox.SelectedIndex == 1) filterId = doiKhachComboBox.SelectedValue.ToString();
            //adjust filter
            raSanSelectorBindingSource2.Filter = "MaDoi = '" + filterId + "' AND CauThuChinhThuc = TRUE AND MaTranDau = '" + GlobalState.selectedMatchId + "'";
            raSanSelectorBindingSource3.Filter = "MaDoi = '" + filterId + "' AND CauThuDuBi = TRUE AND MaTranDau = '" + GlobalState.selectedMatchId + "'";
        }

        private void themThayNguoi_Click(object sender, EventArgs e)
        {
            int minutes = Int16.Parse(phutThayNguoi.Value.ToString());
            int second = Int16.Parse(giayThayNguoi.Value.ToString());
            TimeSpan time = new TimeSpan(0, minutes, second);

            string timeString = time.ToString();

            bool checkComboBox = (doiThayNguoiComboBox.Text == "");
            bool checkTimeEvent = checkTime(timeString, dataGridView6, 5);

            if (checkComboBox && checkTimeEvent)
            {
                MessageBox.Show("Hãy chọn đội bóng!");
            }
            else
            if ((!checkTimeEvent && checkComboBox) || (!checkComboBox && !checkTimeEvent))
            {
                MessageBox.Show("Thời điểm đã trùng");
            }
            else
            {
                try
                {
                    //Console.WriteLine(cauThuVaoSanComboBox.SelectedValue.ToString());
                    //Console.WriteLine(cauThuRaSanComboBox.SelectedValue.ToString());
                    CHITIETTHAYNGUOI thaynguoi = new CHITIETTHAYNGUOI()
                    {
                        MaCauThuVaoSan = cauThuVaoSanComboBox.SelectedValue.ToString(),
                        MaCauThuRaSan = cauThuRaSanComboBox.SelectedValue.ToString(),
                        ThoiDiem = new TimeSpan(0, Int16.Parse(phutThayNguoi.Value.ToString()), Int16.Parse(giayThayNguoi.Value.ToString())),
                        MaTranDau = GlobalState.selectedMatchId
                    };

                    Database.ChiTietThayNguoi_DAO.createChiTietThayNguoi(thaynguoi);
                    this.thayNguoiExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.ThayNguoiExt);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
            
        }

        private void themThePhat_Click(object sender, EventArgs e)
        {
            int minutes = Int16.Parse(phutPhamLoi.Value.ToString());
            int second = Int16.Parse(giayPhamLoi.Value.ToString());
            TimeSpan time = new TimeSpan(0, minutes, second);

            string timeString = time.ToString();

            bool checkComboBox = (doiPhamLoiComboBox.Text == "");
            bool checkTimeEvent = checkTime(timeString, danhSachPhamLoiData, 4);

            if (checkComboBox && checkTimeEvent)
            {
                MessageBox.Show("Hãy chọn đội bóng!");
            }
            else
            if ((!checkTimeEvent && checkComboBox) || (!checkComboBox && !checkTimeEvent))
            {
                MessageBox.Show("Thời điểm đã trùng");
            }
            else
            {
                try
                {
                    PHATTHE phatthe = new PHATTHE()
                    {
                        MaTranDau = GlobalState.selectedMatchId,
                        MaCauThu = cauThuPhamLoiComboBox.SelectedValue.ToString(),
                        MaLoaiThe = loaiThePhatComboBox.SelectedValue.ToString(),
                        ThoiDiem = new TimeSpan(0, Int16.Parse(phutPhamLoi.Value.ToString()), Int16.Parse(giayPhamLoi.Value.ToString())),
                        MaPhatThe = GlobalState.selectedMatchId,
                    };
                    Database.PhatThe_DAO.createPhatThe(phatthe);
                    this.thePhatExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.ThePhatExt);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
   
        }

        private void themBanThang_Click(object sender, EventArgs e)
        {

            int minutes = Int16.Parse(phutGhiBan.Value.ToString());
            int second = Int16.Parse(giayGhiBan.Value.ToString());
            TimeSpan time = new TimeSpan(0, minutes, second);

            string timeString = time.ToString();

            bool checkComboBox = (doiGhiBanComboBox.Text == "");
            bool checkTimeEvent = checkTime(timeString, danhSachGhiBanData, 4);

            if (checkComboBox && checkTimeEvent)
            {
                MessageBox.Show("Hãy chọn đội bóng!");
            }
            else
            if ((!checkTimeEvent && checkComboBox) || (!checkComboBox && !checkTimeEvent))
            {
                MessageBox.Show("Thời điểm đã trùng");
            }
            else
            {
                try
                {
                    BANTHANG banThang = new BANTHANG()
                    {
                        MaCauThu = cauThuGhiBanComboBox.SelectedValue.ToString(),
                        MaLoaiBanThang = loaiBanThangComboBox.SelectedValue.ToString(),
                        ThoiDiem = new TimeSpan(0, Int16.Parse(phutGhiBan.Value.ToString()), Int16.Parse(giayGhiBan.Value.ToString())),
                        MaTranDau = GlobalState.selectedMatchId
                    };
                    Database.BanThang_DAO.createBanThang(banThang);
                    this.banThangExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.BanThangExt);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    //TODO: update game score
                    int tiSoNha; int tiSoKhach;
                    Database.TranDau_DAO.loadTiSoTranDau(GlobalState.selectedMatchId, out tiSoNha, out tiSoKhach);
                    tiSoDoiNha.Text = tiSoNha.ToString();
                    tiSoDoiKhach.Text = tiSoKhach.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void xoaBanThang_Click(object sender, EventArgs e)
        {
            //check if respective data view have at least a selected cell, then YOLO
            if (xoaBanThang.Text.Equals("Xóa"))
            {
                if (danhSachGhiBanData.SelectedCells.Count == 0 || danhSachGhiBanData.SelectedCells[0].RowIndex < 0)
                {
                    MessageBox.Show("Xin hãy chọn thông tin 1 bàn thắng trong bảng để xóa", "Thông báo");
                    return;
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa bàn thắng này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Database.BanThang_DAO.removeBanThang(danhSachGhiBanData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            banThangExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.BanThangExt);
                            int tiSoNha; int tiSoKhach;
                            Database.TranDau_DAO.loadTiSoTranDau(GlobalState.selectedMatchId, out tiSoNha, out tiSoKhach);
                            tiSoDoiNha.Text = tiSoNha.ToString();
                            tiSoDoiKhach.Text = tiSoKhach.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi xảy ra");
                        }
                    }
                }
            }
            else if (xoaBanThang.Text.Equals("Hủy"))
            {
                //not update goal info
                selectedGoalId = "";

                suaBanThang.Text = "Sửa";
                xoaBanThang.Text = "Xóa";
                themBanThang.Enabled = true;
            }
        }

        private void suaBanThang_Click(object sender, EventArgs e)
        {
            if (suaBanThang.Text.Equals("Sửa"))
            {
                if (danhSachGhiBanData.SelectedCells.Count == 0 || danhSachGhiBanData.SelectedCells[0].RowIndex < 0)
                {
                    MessageBox.Show("Xin hãy chọn thông tin 1 bàn thắng trong bảng để chỉnh sửa", "Thông báo");
                    return;
                }
                else
                {
                    BANTHANG banThang;
                    selectedGoalId = danhSachGhiBanData.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                    try
                    {
                        Database.BanThang_DAO.selectBanThang(selectedGoalId, out banThang);
                        cauThuGhiBanComboBox.SelectedValue = banThang.MaCauThu;
                        loaiBanThangComboBox.SelectedValue = banThang.MaLoaiBanThang;
                        phutGhiBan.Value = banThang.ThoiDiem.Hours * 60 + banThang.ThoiDiem.Minutes;
                        giayGhiBan.Value = banThang.ThoiDiem.Seconds;
                        xoaBanThang.Text = "Hủy";
                        suaBanThang.Text = "Lưu";
                        themBanThang.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi xảy ra");
                    }
                    
                }
            }
            else if (suaBanThang.Text.Equals("Lưu"))
            {
                //check for database inconsitency (if server wont handle)

                //update goal infotry
                try
                {
                    BANTHANG banThang = new BANTHANG()
                    {
                        MaBanThang = selectedGoalId,
                        MaCauThu = cauThuGhiBanComboBox.SelectedValue.ToString(),
                        MaLoaiBanThang = loaiBanThangComboBox.SelectedValue.ToString(),
                        ThoiDiem = new TimeSpan(0, Int16.Parse(phutGhiBan.Value.ToString()), Int16.Parse(giayGhiBan.Value.ToString())),
                        MaTranDau = GlobalState.selectedMatchId
                    };
                    Database.BanThang_DAO.updateBanThang(banThang);
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    banThangExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.BanThangExt);
                    selectedGoalId = "";
                    xoaBanThang.Text = "Xóa";
                    suaBanThang.Text = "Sửa";
                    themBanThang.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void xoaThePhat_Click(object sender, EventArgs e)
        {
            if (xoaThePhat.Text.Equals("Xóa"))
            {
                if (danhSachPhamLoiData.SelectedCells.Count == 0 || danhSachPhamLoiData.SelectedCells[0].RowIndex < 0)
                {
                    MessageBox.Show("Xin hãy chọn thông tin 1 thẻ phạt trong bảng để xóa", "Thông báo");
                    return;
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa thẻ phạt này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Database.PhatThe_DAO.removePhatThe(danhSachPhamLoiData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            thePhatExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.ThePhatExt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi xảy ra");
                        }
                    }
                }
            }
            else if (xoaThePhat.Text.Equals("Hủy"))
            {
                //not update foul info
                selectedFoulId = "";

                xoaThePhat.Text = "Xóa";
                suaThePhat.Text = "Sửa";

                themThePhat.Enabled = true;
            }
        }

        private void suaThePhat_Click(object sender, EventArgs e)
        {
            if (suaThePhat.Text.Equals("Sửa"))
            {
                if (danhSachPhamLoiData.SelectedCells.Count == 0 || danhSachPhamLoiData.SelectedCells[0].RowIndex < 0)
                {
                    MessageBox.Show("Xin hãy chọn thông tin 1 thẻ phạt trong bảng để chỉnh sửa", "Thông báo");
                    return;
                }
                else
                {
                    selectedFoulId = danhSachPhamLoiData.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                    try
                    {
                        PHATTHE phatthe;
                        Database.PhatThe_DAO.selectPhatThe(selectedFoulId,out phatthe);
                        cauThuPhamLoiComboBox.SelectedValue = phatthe.MaCauThu;
                        loaiThePhatComboBox.SelectedValue = phatthe.MaLoaiThe;
                        phutPhamLoi.Value = phatthe.ThoiDiem.Hours * 60 + phatthe.ThoiDiem.Minutes;
                        giayPhamLoi.Value = phatthe.ThoiDiem.Seconds;

                        xoaThePhat.Text = "Hủy";
                        suaThePhat.Text = "Lưu";
                        themThePhat.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi xảy ra");
                    }
                }
            }
            else if (suaThePhat.Text.Equals("Lưu"))
            {
                //update foul info

                try
                {
                    PHATTHE phatthe = new PHATTHE()
                    {
                        MaPhatThe = selectedFoulId,
                        MaCauThu= cauThuPhamLoiComboBox.SelectedValue.ToString(),
                        MaLoaiThe= loaiThePhatComboBox.SelectedValue.ToString(),
                        ThoiDiem= new TimeSpan(0, Int16.Parse(phutPhamLoi.Value.ToString()), Int16.Parse(giayPhamLoi.Value.ToString())),
                        MaTranDau= GlobalState.selectedMatchId,
                    };
                    Database.PhatThe_DAO.updatePhatThe(phatthe);
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    thePhatExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.ThePhatExt);
                    selectedFoulId = "";
                    xoaThePhat.Text = "Xóa";
                    suaThePhat.Text = "Sửa";
                    themThePhat.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void themDoiNha_Click(object sender, EventArgs e)
        {
            try
            {
                DANHSACHTHAMGIA dsThamGia = new DANHSACHTHAMGIA()
                {
                    MaTranDau = GlobalState.selectedMatchId,
                    MaCauThu = cauThuDoiNhaComboBox.SelectedValue.ToString(),
                    CauThuChinhThuc = false,
                    CauThuDuBi = false
                };
                Database.DanhSachThamGia_DAO.createDanhSachThamGia(dsThamGia);
                this.raSanExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanExt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }

        private void xoaDoiNha_Click(object sender, EventArgs e)
        {
            if (danhSachCauThuDoiNhaData.SelectedCells.Count == 0 || danhSachCauThuDoiNhaData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn thông tin 1 cầu thủ trong trong bảng để xóa khỏi danh sách tham gia", "Thông báo");
                return;
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa cầu thủ này khỏi danh sách tham gia?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Database.DanhSachThamGia_DAO.removeDanhSachThamGia(GlobalState.selectedMatchId, danhSachCauThuDoiNhaData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        this.raSanExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanExt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi xảy ra");
                    }
                }
            }
        }

        private void themDoiKhach_Click(object sender, EventArgs e)
        {
            try
            {

                DANHSACHTHAMGIA dsThamGia = new DANHSACHTHAMGIA()
                {
                    MaTranDau = GlobalState.selectedMatchId,
                    MaCauThu = cauThuDoiKhachComboBox.SelectedValue.ToString(),
                    CauThuChinhThuc = false,
                    CauThuDuBi = false
                };
                Database.DanhSachThamGia_DAO.createDanhSachThamGia(dsThamGia);
                this.raSanExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanExt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }

        private void xoaDoiKhach_Click(object sender, EventArgs e)
        {
            if (danhSachCauThuDoiKhachData.SelectedCells.Count == 0 || danhSachCauThuDoiKhachData.SelectedCells[0].RowIndex < 0)
            {
                MessageBox.Show("Xin hãy chọn thông tin 1 cầu thủ trong trong bảng để xóa khỏi danh sách tham gia", "Thông báo");
                return;
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa cầu thủ này khỏi danh sách tham gia?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Database.DanhSachThamGia_DAO.removeDanhSachThamGia(GlobalState.selectedMatchId, danhSachCauThuDoiKhachData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        this.raSanExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.RaSanExt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi xảy ra");
                    }
                }
            }
        }

        private void suaThayNguoi_Click(object sender, EventArgs e)
        {
            if (suaThayNguoi.Text.Equals("Sửa"))
            {
                if (dataGridView6.SelectedCells.Count == 0 || dataGridView6.SelectedCells[0].RowIndex < 0)
                {
                    MessageBox.Show("Xin hãy chọn thông tin 1 thay người trong bảng để chỉnh sửa", "Thông báo");
                    return;
                }
                else
                {
                    //load change info into the fields
                    CHITIETTHAYNGUOI thaynguoi;
                    selectedChangeId = dataGridView6.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                    try
                    {
                        Database.ChiTietThayNguoi_DAO.selectChiTietThayNguoi(selectedChangeId, out thaynguoi);
                        cauThuVaoSanComboBox.SelectedValue = thaynguoi.MaCauThuVaoSan;
                        cauThuRaSanComboBox.SelectedValue = thaynguoi.MaCauThuRaSan;
                        phutThayNguoi.Value = thaynguoi.ThoiDiem.Hours * 60 + thaynguoi.ThoiDiem.Minutes;
                        giayThayNguoi.Value = thaynguoi.ThoiDiem.Seconds;

                        xoaThayNguoi.Text = "Hủy";
                        suaThayNguoi.Text = "Lưu";

                        themThayNguoi.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi xảy ra");
                    }
                }
            }
            else if (suaThayNguoi.Text.Equals("Lưu"))
            {
                //check for database inconsitency (if server wont handle)

                //update change info
                try
                {
                    CHITIETTHAYNGUOI thaynguoi = new CHITIETTHAYNGUOI()
                    {
                        MaThayNguoi = selectedChangeId,
                        MaCauThuVaoSan = cauThuVaoSanComboBox.SelectedValue.ToString(),
                        MaCauThuRaSan = cauThuRaSanComboBox.SelectedValue.ToString(),
                        ThoiDiem = new TimeSpan(0, Int16.Parse(phutThayNguoi.Value.ToString()), Int16.Parse(giayThayNguoi.Value.ToString())),
                        MaTranDau = GlobalState.selectedMatchId
                    };
                    Database.ChiTietThayNguoi_DAO.updateChiTietThayNguoi(thaynguoi);
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    thayNguoiExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.ThayNguoiExt);
                    selectedChangeId = "";
                    xoaThayNguoi.Text = "Xóa";
                    suaThayNguoi.Text = "Sửa";

                    themThayNguoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }                
            }
        }

        private void xoaThayNguoi_Click(object sender, EventArgs e)
        {
            if (xoaThayNguoi.Text.Equals("Xóa"))
            {
                if (dataGridView6.SelectedCells.Count == 0 || dataGridView6.SelectedCells[0].RowIndex < 0)
                {
                    MessageBox.Show("Xin hãy chọn thông tin 1 thay người trong bảng để xóa", "Thông báo");
                    return;
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa thông tin thay người này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Database.ChiTietThayNguoi_DAO.removeChiTietThayNguoi(dataGridView6.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            thayNguoiExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.ThayNguoiExt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi xảy ra");
                        }
                    }
                }
            }
            else if (xoaThayNguoi.Text.Equals("Hủy"))
            {
                //not update player change info
                selectedChangeId = "";

                xoaThayNguoi.Text = "Xóa";
                suaThayNguoi.Text = "Sửa";

                themThayNguoi.Enabled = true;
            }
        }
        
        private bool checkTime(string time, DataGridView data, int index)
        {
            for (int i = 0; i < data.Rows.Count; ++i)
            {
                var value = data.Rows[i].Cells[index].Value.ToString();
                if (time == value)
                {
                    return false;
                }
            }

            return true;
        }

        
        private void PhutGhiBan_Validating(object sender, CancelEventArgs e)
        {
            //TimeSpan time = new TimeSpan(0, Int16.Parse(phutGhiBan.Value.ToString());
            int minutes = Int16.Parse(phutGhiBan.Value.ToString());
            int second = Int16.Parse(giayGhiBan.Value.ToString());
            TimeSpan time = new TimeSpan(0, minutes , second);

            string timeString = time.ToString();

            if (!checkTime(timeString, danhSachGhiBanData, 4))
            {
                //e.Cancel = true;
                //soAoPicker.Focus();
                errorProvider.SetIconAlignment(phutGhiBan, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(phutGhiBan, "Thời điểm không chính xác!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(phutGhiBan, null);
            }

        }

        private void PhutPhamLoi_Validating(object sender, CancelEventArgs e)
        {
            //TimeSpan time = new TimeSpan(0, Int16.Parse(phutGhiBan.Value.ToString());
            int minutes = Int16.Parse(phutPhamLoi.Value.ToString());
            int second = Int16.Parse(giayPhamLoi.Value.ToString());
            TimeSpan time = new TimeSpan(0, minutes, second);

            string timeString = time.ToString();

            if (!checkTime(timeString, danhSachPhamLoiData, 4))
            {
                //e.Cancel = true;
                //soAoPicker.Focus();
                errorProvider.SetIconAlignment(phutPhamLoi, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(phutPhamLoi, "Thời điểm không chính xác!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(phutPhamLoi, null);
            }
        }

        private void PhutThayNguoi_Validating(object sender, CancelEventArgs e)
        {
            //TimeSpan time = new TimeSpan(0, Int16.Parse(phutGhiBan.Value.ToString());
            int minutes = Int16.Parse(phutThayNguoi.Value.ToString());
            int second = Int16.Parse(giayThayNguoi.Value.ToString());
            TimeSpan time = new TimeSpan(0, minutes, second);

            string timeString = time.ToString();

            if (!checkTime(timeString, dataGridView6, 5))
            {
                //e.Cancel = true;
                //soAoPicker.Focus();
                errorProvider.SetIconAlignment(phutThayNguoi, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(phutThayNguoi, "Thời điểm không chính xác!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(phutThayNguoi, null);
            }
        }

        private void DoiGhiBanComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (doiGhiBanComboBox.Text == "")
            {
                errorProvider.SetIconAlignment(doiGhiBanComboBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(doiGhiBanComboBox, "Hãy chọn đội bóng!");
            }
            else
            {
                errorProvider.SetError(doiGhiBanComboBox, null);
            }
        }

        private void DoiPhamLoiComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (doiPhamLoiComboBox.Text == "")
            {
                errorProvider.SetIconAlignment(doiPhamLoiComboBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(doiPhamLoiComboBox, "Hãy chọn đội bóng!");
            }
            else
            {
                errorProvider.SetError(doiPhamLoiComboBox, null);
            }
        }

        private void DoiThayNguoiComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (doiThayNguoiComboBox.Text == "")
            {
                errorProvider.SetIconAlignment(doiThayNguoiComboBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(doiThayNguoiComboBox, "Hãy chọn đội bóng!");
            }
            else
            {
                errorProvider.SetError(doiThayNguoiComboBox, null);
            }
        }
    }
}
