using QuanLyGiaiVoDich.DTO_Class.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiVoDich
{
    public partial class TiepNhanHoSo : Form
    {
        private string selectedTeamId = "";
        private DataGridViewRow selectedRow;
        private Boolean isUpdate = false;
        private bool surpressDiscardPrompt = false;

        // initialize components
        //private int tuoiToiThieu;
        //private int tuoiToiDa;
        //private int soLuongCauThuToiDa, soCauThuToiThieu, soLanThayNguoiToiDa, diemSoThang, diemSoThua, diemSoHoa, soCauThuNuocNgoaiToiDa;

        private DIEUKIEN dieuKien;
        // amount of soccer player in team
        private int soLuongCauThu;

        public TiepNhanHoSo()
        {
            InitializeComponent();
            soLuongCauThu = 0;

            // Load data to DieuKien objects
            Database.DieuKien_DAO.selectDieuKien(GlobalState.selectedSeasonId, out dieuKien);
        }

        public TiepNhanHoSo(string v)
        {
            this.selectedTeamId = v;

            InitializeComponent();
            Database.DieuKien_DAO.selectDieuKien(GlobalState.selectedSeasonId, out dieuKien);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //TODO: validate input field 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                themCauThu.Enabled = true;
                soLuongCauThu++;
                // if team's not full player
                if (soLuongCauThu <= dieuKien.SoCauThuToiDa)
                {
                    //add data to column
                    themCauThu.Enabled = true;
                    String[] row = { (danhSachCauThuData.Rows.Count + 1).ToString(), soAoPicker.Value.ToString(), Guid.NewGuid().ToString(), tenCauThuTextBox.Text, ngaySinhPicker.Value.ToString(), loaiCauThuComboBox.Text, ghiChuTextBox.Text };
                    danhSachCauThuData.Rows.Add(row);

                    //reset input fields
                    maCauThuTextBox.Text = "";
                    tenCauThuTextBox.Text = "";
                    ngaySinhPicker.Value = DateTime.Now;
                    loaiCauThuComboBox.SelectedValue = "0";
                    soAoPicker.Value = 1;
                    ghiChuTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Số lượng cầu thủ đã đầy");
                    themCauThu.Enabled = false;
                }

            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            this.isUpdate = true;
            ThemSanThiDau form = new ThemSanThiDau();
            form.ShowDialog();
        }

        private void TiepNhanHoSo_Load(object sender, EventArgs e)
        {
            //load data
            this.loaiCauThuAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiCauThuAllowNull);
            this.sanThiDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauAllowNull);
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            suaCauthu.Enabled = false;
            xoaCauthu.Enabled = false;
            muaGiaiComboBox.SelectedValue = GlobalState.selectedSeasonId;

            sanThiDauAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaSanThiDau = '0'";
            loaiCauThuAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' OR MaLoaiCauThu = '0'";

            // Load data to regulation
            quyDinhTuoiLabel.Text = "Từ " + dieuKien.TuoiToiThieu.ToString() + " Đến " + dieuKien.TuoiToiDa.ToString();
            soLuongCauThuToiDaLabel.Text = dieuKien.SoCauThuToiDa.ToString() + " Người";
            soLuongCauThuNuocNgoaiToiDaLabel.Text = dieuKien.SoCauThuNuocNgoaiToiDa.ToString() + " Người";

            if (!selectedTeamId.Equals(""))
            {
                tenDoiTextBox.Text = Database.DoiBong_DAO.queryTenDoiBong(selectedTeamId);
                string MaSanNha = Database.SanThiDau_DAO.queryMaSanNha(selectedTeamId);
                if (!MaSanNha.Equals("")) sanNhaComboBox.SelectedValue = MaSanNha;
                groupBox3.Text = "Danh sách cầu thủ mới";
                khoiTaoDoiBongButton.Text = "Lưu thông tin đội bóng";
            }
        }

        private void danhSachCauThuData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (danhSachCauThuData.CurrentRow.Index < 0) return;
            selectedRow = danhSachCauThuData.CurrentRow;
            suaCauthu.Enabled = true;
            xoaCauthu.Enabled = true;
        }

        private void suaCauthu_Click(object sender, EventArgs e)
        {
            if (suaCauthu.Text.Equals("Lưu"))
            {
                //TODO: Validate entry
                //save edited entry
                selectedRow.Cells[3].Value = tenCauThuTextBox.Text;
                selectedRow.Cells[4].Value = ngaySinhPicker.Value;
                selectedRow.Cells[5].Value = loaiCauThuComboBox.Text;
                selectedRow.Cells[6].Value = ghiChuTextBox.Text;
                selectedRow.Cells[1].Value = soAoPicker.Value.ToString();

                //unload editing data
                maCauThuTextBox.Text = "";
                tenCauThuTextBox.Text = "";
                ngaySinhPicker.Value = DateTime.Now;
                loaiCauThuComboBox.SelectedValue = "0";
                ghiChuTextBox.Text = "";

                //reset buttons to their original state
                themCauThu.Enabled = true;
                suaCauthu.Text = "Sửa";
                xoaCauthu.Text = "Xóa";
                suaCauthu.Enabled = false;
                xoaCauthu.Enabled = false;
            }
            else if (suaCauthu.Text.Equals("Sửa"))
            {
                //load selected entry info into the boxes and change button name to "Lưu" and "Hủy"
                soAoPicker.Value = Int32.Parse(selectedRow.Cells[1].Value.ToString());
                maCauThuTextBox.Text = selectedRow.Cells[2].Value.ToString();
                tenCauThuTextBox.Text = selectedRow.Cells[3].Value.ToString();
                ngaySinhPicker.Value = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                loaiCauThuComboBox.Text = selectedRow.Cells[5].Value.ToString();
                ghiChuTextBox.Text = selectedRow.Cells[6].Value.ToString();

                themCauThu.Enabled = false;
                suaCauthu.Text = "Lưu";
                xoaCauthu.Text = "Hủy";
            }
        }

        private void xoaCauthu_Click(object sender, EventArgs e)
        {
            if (xoaCauthu.Text.Equals("Hủy"))
            {
                //unload editing data
                maCauThuTextBox.Text = "";
                tenCauThuTextBox.Text = "";
                ngaySinhPicker.Value = DateTime.Now;
                loaiCauThuComboBox.SelectedValue = "0";
                soAoPicker.Value = 1;
                ghiChuTextBox.Text = "";

                //reset buttons to their original state
                themCauThu.Enabled = true;
                suaCauthu.Text = "Sửa";
                xoaCauthu.Text = "Xóa";
                suaCauthu.Enabled = false;
                xoaCauthu.Enabled = false;
            }
            else if (xoaCauthu.Text.Equals("Xóa"))
            {
                //ask user if they want to delete this entry
                if (soLuongCauThu > dieuKien.SoCauThuToiDa)
                    soLuongCauThu -= 2;
                else
                    soLuongCauThu--;

                this.isUpdate = false;
                var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu cầu thủ này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    danhSachCauThuData.Rows.Remove(selectedRow);
                    selectedRow = null;
                    suaCauthu.Enabled = false;
                    xoaCauthu.Enabled = false;
                    themCauThu.Enabled = true;

                    //refresh ordering number
                    int x = 1;
                    foreach (DataGridViewRow it_row in danhSachCauThuData.Rows)
                    {
                        it_row.Cells[0].Value = x.ToString();
                        x += 1;
                    }
                }
            }
        }

        private void khoiTaoDoiBongButton_Click(object sender, EventArgs e)
        {
            //TODO: validate input
            //adding all player record from temporary player table and team info to database

            // Kiểm tra validate
            if (ValidateChildren(ValidationConstraints.ImmediateChildren | ValidationConstraints.Enabled))
            {
                if (sanNhaComboBox.SelectedIndex == 0 || sanNhaComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Hãy chọn sân nhà thi đấu!");
                    return;
                }
                try
                {
                    String tenSan, donViSoHuu, maDoiNha;
                    Database.SanThiDau_DAO.selectSanThiDau(sanNhaComboBox.SelectedValue.ToString(), out tenSan, out donViSoHuu, out maDoiNha);
                    if ((!maDoiNha.Equals("")) && (!maDoiNha.Equals(selectedTeamId)))
                    {
                        var result = MessageBox.Show("Sân bạn chọn là sân nhà của một đội khác. Nếu tiếp tục, sân đã chọn sẽ không còn là sân nhà của đội bóng đó. Tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }

                    DOIBONG doiBong = new DOIBONG()
                    {
                        TenDoi = tenDoiTextBox.Text,
                        MaMuaGiai = GlobalState.selectedSeasonId
                    };
                    if (selectedTeamId.Equals(""))
                    {
                        //insert team                        
                        Database.DoiBong_DAO.createDoiBong(doiBong);
                        //retrive newly created id
                        doiBong.MaDoi = Database.DoiBong_DAO.queryMaDoiBong(tenDoiTextBox.Text, GlobalState.selectedSeasonId);
                        //update home stadium
                        //Console.WriteLine(sanNhaComboBox.SelectedValue.ToString());
                        Database.SanThiDau_DAO.updateSanThiDau(sanNhaComboBox.SelectedValue.ToString(), tenSan, donViSoHuu, doiBong.MaDoi);
                        KETQUADOIBONG kq = new KETQUADOIBONG(doiBong.MaDoi);
                        Database.KetQuaDoiBong_DAO.createKetQuaDoiBong(kq);
                    }
                    else
                    {
                        doiBong.MaDoi = selectedTeamId;
                        Database.DoiBong_DAO.updateDoiBong(doiBong);
                        Database.SanThiDau_DAO.updateSanThiDau(sanNhaComboBox.SelectedValue.ToString(), tenSan, donViSoHuu, selectedTeamId);
                    }
                    foreach (DataGridViewRow it_row in danhSachCauThuData.Rows)
                    {
                        CAUTHU cauthu = new CAUTHU()
                        {
                            TenCauThu = it_row.Cells[3].Value.ToString(),
                            NgaySinh = DateTime.Parse(it_row.Cells[4].Value.ToString()),
                            MaLoaiCauThu = Database.LoaiCauThu_DAO.queryMaLoaiCauThu(it_row.Cells[5].Value.ToString(), GlobalState.selectedSeasonId),
                            GhiChu = it_row.Cells[6].Value.ToString(),
                            MaDoi = doiBong.MaDoi,
                            SoBanThang = 0,
                            SoAo = Int16.Parse(it_row.Cells[1].Value.ToString())
                        };
                        Database.CauThu_DAO.createCauThu(cauthu);
                    }
                    //TODO: run stored procedure to check for minimum player count
                    string res = Database.DoiBong_DAO.checkSoCauThuToiThieu(doiBong.MaDoi);
                    if (!res.Equals("Thỏa điều kiện số cầu thủ tối thiểu")) MessageBox.Show(res, "Thông báo");
                    //create new team result record
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    //TODO: close form on saving
                    surpressDiscardPrompt = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }    
            }     
        }

        private void TiepNhanHoSo_Activated(object sender, EventArgs e)
        {
            if (!isUpdate) return;
            //update loaded data
            this.sanThiDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauAllowNull);
            isUpdate = false;
        }

        private void TiepNhanHoSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (surpressDiscardPrompt) return;
            var result = MessageBox.Show("Thay đổi này sẽ không được lưu nếu bạn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TenDoiTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void MuaGiaiComboBox_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra comboBox được chọn hay chưa? 
            if (muaGiaiComboBox.SelectedIndex < 0)
            {
                e.Cancel = true;
                muaGiaiComboBox.Focus();
                errorProvider_khoiTaoDoiBong.SetIconAlignment(muaGiaiComboBox, ErrorIconAlignment.MiddleLeft);
                errorProvider_khoiTaoDoiBong.SetError(muaGiaiComboBox, "Hãy chọn mùa giải phù hợp!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_khoiTaoDoiBong.SetError(muaGiaiComboBox, null);
            }
        }

        private void SanNhaComboBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TenCauThuTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra tên cầu thủ chưa được nhập sẽ hiện lỗi
            if (string.IsNullOrEmpty(tenCauThuTextBox.Text))
            {
                e.Cancel = true;
                errorProvider_khoiTaoCauThu.SetIconAlignment(tenCauThuTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider_khoiTaoCauThu.SetError(tenCauThuTextBox, "Hãy điền đầy đủ thông tin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_khoiTaoCauThu.SetError(tenCauThuTextBox, null);
            }
        }

        private void LoaiCauThuComboBox_Validating(object sender, CancelEventArgs e)
        {

        }


        // Tính độ tuổi của cầu thủ để kiểm tra có phù hợp với điều kiện
        private int tinhTuoiCauThu(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;

            // Nếu chưa đến sinh nhật thì tuổi - 1
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;

            return age;

        }

        private void NgaySinhPicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateOfBirth = ngaySinhPicker.Value;

            int age = new int();
            age = tinhTuoiCauThu(dateOfBirth);

            //Console.WriteLine(tuoiToiDa.ToString() + " " + tuoiToiThieu.ToString());

            // Kiểm tra tuổi không phù hợp sẽ hiện lỗi
            if (age < dieuKien.TuoiToiThieu || age > dieuKien.TuoiToiDa)
            {
                e.Cancel = true;
                //ngaySinhPicker.Focus();
                errorProvider_khoiTaoCauThu.SetIconAlignment(ngaySinhPicker, ErrorIconAlignment.MiddleLeft);
                errorProvider_khoiTaoCauThu.SetError(ngaySinhPicker, "Ngày sinh không phù hợp với điều kiện!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_khoiTaoCauThu.SetError(ngaySinhPicker, null);
            }

        }

        private void TiepNhanHoSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    try
                    {
                        helper.importHelper.importHoSoDoiBong(ofd.FileName, ref danhSachCauThuData, ref tenDoiTextBox, ref sanNhaComboBox);
                        MessageBox.Show("Nhập thông tin từ file thành công", "Thông báo");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Không thể đọc nội dung file: " + ex.Message, "Lỗi xảy ra");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi xảy ra");
                    }
                }
                else
                {
                    MessageBox.Show("File bạn chọn không tồn tại", "Lỗi xảy ra");
                }
            }
        }

        // Kiểm tra số áo cầu thủ có bị trùng ???
        private bool checkSoAo(string number)
        {
            for (int i = 0; i < danhSachCauThuData.Rows.Count; ++i)
            {
                var value = danhSachCauThuData.Rows[i].Cells[1].Value.ToString();
                if (number == value)
                {
                    return false;
                }
            }

            return true;
        }

        private void SoAoPicker_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra nếu trùng số áo thì sẽ hiện lỗi
            if (!checkSoAo(soAoPicker.Value.ToString()))
            {
                e.Cancel = true;
                //soAoPicker.Focus();
                errorProvider_khoiTaoCauThu.SetIconAlignment(soAoPicker, ErrorIconAlignment.MiddleLeft);
                errorProvider_khoiTaoCauThu.SetError(soAoPicker, "Số áo bị trùng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_khoiTaoCauThu.SetError(soAoPicker, null);
            }
        }

        private void SanNhaComboBox_Validating_1(object sender, CancelEventArgs e)
        {
            // Kiểm tra comboBox được chọn hay chưa? 
            if (sanNhaComboBox.SelectedValue == null || sanNhaComboBox.SelectedValue.ToString().Equals("0"))
            {
                e.Cancel = true;
                errorProvider_khoiTaoDoiBong.SetIconAlignment(sanNhaComboBox, ErrorIconAlignment.MiddleLeft);
                errorProvider_khoiTaoDoiBong.SetError(sanNhaComboBox, "Hãy chọn sân đấu phù hợp!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_khoiTaoDoiBong.SetError(sanNhaComboBox, null);
            }
        }

        private void TenDoiTextBox_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tenDoiTextBox.Text))
            {
                e.Cancel = true;
                errorProvider_khoiTaoDoiBong.SetIconAlignment(tenDoiTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider_khoiTaoDoiBong.SetError(tenDoiTextBox, "Hãy điền đầy đủ thông tin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_khoiTaoDoiBong.SetError(tenDoiTextBox, null);
            }
        }

        private void LoaiCauThuComboBox_Validating_1(object sender, CancelEventArgs e)
        {
            // Kiểm tra comboBox được chọn hay chưa? 
            if (loaiCauThuComboBox.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider_khoiTaoCauThu.SetIconAlignment(loaiCauThuComboBox, ErrorIconAlignment.MiddleLeft);
                errorProvider_khoiTaoCauThu.SetError(loaiCauThuComboBox, "Hãy chọn loại cầu thủ phù hợp!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_khoiTaoCauThu.SetError(loaiCauThuComboBox, null);
            }
        }

        private void tenDoiTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
