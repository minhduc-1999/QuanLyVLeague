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
    public partial class ThayDoiQuyDinh : Form
    {

        private bool isPlayerTypeUpdated = false;
        private bool isGoalTypeUpdated = false;
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        // Thêm loại bàn thắng vào listBox bằng dấu "+"
        public void getValue_LoaiBanThang(string value)
        {
            if (value != "") 
                loaiBanThangListBox.Items.Add(value);
        }

        // Thêm loại cầu thủ vào listBox bằng dấu "+"
        public void getValue_LoaiCauThu(string value)
        {
            if (value != "")
                loaiCauThuListBox.Items.Add(value);
        }

        // Nhận dữ liệu từ file themLoaiBanThang.cs
        private void ThemLoaiBanThangButton_Click(object sender, EventArgs e)
        {
            themThongTin form = new themThongTin();

            //form.myData = new themThongTin.getData(getValue_LoaiBanThang);

            //// Đặt tên cho groupBox của Dialog nhập thông tin
            form.Message = "Thêm Loại Bàn Thắng";
            form.CacLoaiCheckBox = "Tính Bàn Cho Cầu Thủ";
            isGoalTypeUpdated = true;
            form.ShowDialog();
        }

        // Nhận dữ liệu từ file themLoaiCauThu.cs
        private void ThemLoaiCauThuButton_Click(object sender, EventArgs e)
        {
            themThongTin form = new themThongTin();

            //form.myData = new themThongTin.getData(getValue_LoaiCauThu);

            //// Đặt tên cho groupBox của Dialog nhập thông tin
            form.Message = "Thêm Loại Cầu Thủ";
            form.CacLoaiCheckBox = "Cầu Thủ Nước Ngoài";
            isPlayerTypeUpdated = true;
            form.ShowDialog();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.LoaiCauThu' table. You can move, or remove it, as needed.
            this.loaiCauThuTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiCauThu);
            this.thuTuUuTienTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.ThuTuUuTien);
            this.loaiBanThangTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiBanThang);

            //int diemThang; int diemHoa; int diemThua; int soCauThuToiThieu; int soCauThuToiDa;
            //int soCauThuNuocNgoaiToiDa; int soLanThayNguoiToiDa; int tuoiToiThieu; int tuoiToiDa;
            DIEUKIEN dieuKien;
            Database.DieuKien_DAO.selectDieuKien(GlobalState.selectedSeasonId, out dieuKien);
            soLuongCauThuMax.Value = dieuKien.SoCauThuToiDa;
            soLuongCauThuMin.Value = dieuKien.SoCauThuToiThieu;
            soLuongNuocNgoaiMax.Value = dieuKien.SoCauThuNuocNgoaiToiDa;
            soLuotThayNguoiMax.Value = dieuKien.SoLanThayNguoiToiDa;
            diemSoThang.Value = dieuKien.DiemSoThang;
            diemSoHoa.Value = dieuKien.DiemSoHoa;
            diemSoThua.Value = dieuKien.DiemSoThua;
            doiTuoiMax.Value = dieuKien.TuoiToiDa;
            doiTuoiMin.Value = dieuKien.TuoiToiThieu;

            this.loaiBanThangBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.thuTuUuTienBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            this.loaiCauThuBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
        }

        // Xóa loại bàn thắng bằng dấu "-"
        private void XoaLoaiBanThangButton_Click(object sender, EventArgs e)
        {
            if (loaiBanThangListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Xin hãy chọn 1 loại bàn thắng để xóa", "Thông báo");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu loại bàn thắng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    String selectedGoalTypeId = (loaiBanThangListBox.SelectedItem as DataRowView)["MaLoaiBanThang"].ToString();
                    Database.LoaiBanThang_DAO.removeLoaiBanThang(selectedGoalTypeId);
                    this.loaiBanThangTableAdapter.Fill(quanLyGiaiVoDichDataSet.LoaiBanThang);
                    MessageBox.Show("Xóa loại bàn thắng thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        // Xóa loại cầu thủ bằng dấu "-"
        private void XoaLoaiCauThuButton_Click(object sender, EventArgs e)
        {
            if (loaiCauThuListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Xin hãy chọn 1 loại cầu thủ để xóa", "Thông báo");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu loại cầu thủ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    String selectedPlayerTypeId = (loaiCauThuListBox.SelectedItem as DataRowView)["MaLoaiCauThu"].ToString();
                    Database.LoaiCauThu_DAO.removeLoaiCauThu(selectedPlayerTypeId);
                    this.loaiCauThuTableAdapter.Fill(quanLyGiaiVoDichDataSet.LoaiCauThu);
                    MessageBox.Show("Xóa loại cầu thủ thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        // Khởi tạo hàm di chuyển up, down các items trong listBox 
        public void moveItem(int direction)
        {
            // Kiểm tra item rỗng?
            if (thuTuXepHangListBox.SelectedIndex == null || thuTuXepHangListBox.SelectedIndex < 0 || thuTuXepHangListBox.Items.Count <= 1)
                return;
            try
            {
                int source_pos = thuTuXepHangListBox.SelectedIndex + 1;
                int dest_pos = source_pos + direction;

                if (source_pos == 4 || dest_pos == 4) return;
                THUTUUUTIEN thutu0 = new THUTUUUTIEN()
                {
                    ChiSoUuTien = source_pos,
                    MaMuaGiai = GlobalState.selectedSeasonId,
                };
                string swap_source = Database.ThuTuUuTien_DAO.selectThuTuUuTien(thutu0);
                THUTUUUTIEN thutui = new THUTUUUTIEN()
                {
                    ChiSoUuTien = dest_pos,
                    MaMuaGiai = GlobalState.selectedSeasonId,
                };
                string swap_dest = Database.ThuTuUuTien_DAO.selectThuTuUuTien(thutui);
                THUTUUUTIEN thutu = new THUTUUUTIEN()
                {
                    ChiSoUuTien= source_pos,
                    MaMuaGiai= GlobalState.selectedSeasonId,
                    TenLoaiUuTien= swap_dest,
                };
                Database.ThuTuUuTien_DAO.updateThuTuUuTien(thutu);
                THUTUUUTIEN thutu1 = new THUTUUUTIEN()
                {
                    ChiSoUuTien = dest_pos,
                    MaMuaGiai = GlobalState.selectedSeasonId,
                    TenLoaiUuTien = swap_source,
                };
                Database.ThuTuUuTien_DAO.updateThuTuUuTien(thutu1);
                thuTuUuTienTableAdapter.Fill(quanLyGiaiVoDichDataSet.ThuTuUuTien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }

        }

        private void TangThuTuXepHangButton_Click(object sender, EventArgs e)
        {
            moveItem(-1);
        }

        private void GiamThuTuXepHang_Click(object sender, EventArgs e)
        {
            moveItem(1);
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            if (isEverythingTrue())
            {
                //TODO: update things
                try
                {
                    DIEUKIEN dk = new DIEUKIEN()
                    {
                        MaMuaGiai = GlobalState.selectedSeasonId,
                        SoCauThuToiThieu = Int16.Parse(soLuongCauThuMin.Value.ToString()),
                        SoCauThuToiDa = Int16.Parse(soLuongCauThuMax.Value.ToString()),
                        TuoiToiDa = Int16.Parse(doiTuoiMax.Value.ToString()),
                        TuoiToiThieu = Int16.Parse(doiTuoiMin.Value.ToString()),
                        SoLanThayNguoiToiDa = Int16.Parse(soLuotThayNguoiMax.Value.ToString()),
                        SoCauThuNuocNgoaiToiDa = Int16.Parse(soLuongNuocNgoaiMax.Value.ToString()),
                        DiemSoHoa = Int16.Parse(diemSoHoa.Value.ToString()),
                        DiemSoThang = Int16.Parse(diemSoThang.Value.ToString()),
                        DiemSoThua = Int16.Parse(diemSoThua.Value.ToString())
                    };
                    Database.DieuKien_DAO.updateDieuKien(dk);

                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Sai các quy định");
            }
            
        }

        private void ThayDoiQuyDinh_Activated(object sender, EventArgs e)
        {
            if (isPlayerTypeUpdated)
            {
                this.loaiCauThuTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiCauThu);
                isPlayerTypeUpdated = false;
            }
            if (isGoalTypeUpdated)
            {
                this.loaiBanThangTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LoaiBanThang);
                isGoalTypeUpdated = false;
            }
        }

        private void doiTuoiMax_Validating(object sender, CancelEventArgs e)
        {
            if (doiTuoiMax.Value < doiTuoiMin.Value)
            {
                //ge.Cancel = true;
                errorProvider.SetIconAlignment(doiTuoiMax, ErrorIconAlignment.MiddleRight);
                errorProvider.SetError(doiTuoiMax, "Thiết lập độ tuổi hợp lý");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(doiTuoiMax, null);
            }
        }

        private void soLuongCauThuMax_Validating(object sender, CancelEventArgs e)
        {
            if (soLuongCauThuMax.Value < soLuongCauThuMin.Value)
            {
                //e.Cancel = true;
                errorProvider.SetIconAlignment(soLuongCauThuMax, ErrorIconAlignment.MiddleRight);
                errorProvider.SetError(soLuongCauThuMax, "Thiết lập độ tuổi hợp lý");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(soLuongCauThuMax, null);
            }
        }

        private bool isDoTuoiTrue()
        {
            if (doiTuoiMax.Value < doiTuoiMin.Value)
                return false;
            return true;
        }

        private bool isSoLuongCauThuTrue()
        {
            if (soLuongCauThuMax.Value < soLuongCauThuMin.Value)
                return false;
            return true;
        }

        private bool isDiemSoTrue()
        {
            if (diemSoThang.Value <= diemSoHoa.Value || diemSoHoa.Value <= diemSoThua.Value
                || diemSoThang.Value <= diemSoThua.Value)
                return false;

            return true;
        }

        private bool isEverythingTrue() {
            if (isDoTuoiTrue() && isSoLuongCauThuTrue() && isDiemSoTrue())
                return true;
            return false;
        }

        private void groupBox4_Validating(object sender, CancelEventArgs e)
        {
            if (diemSoThang.Value <= diemSoHoa.Value || diemSoHoa.Value <= diemSoThua.Value
                || diemSoThang.Value <= diemSoThua.Value)
            {
                errorProvider.SetIconAlignment(groupBox4, ErrorIconAlignment.TopRight);
                errorProvider.SetError(groupBox4, "Điểm phải thỏa mãn: Thắng < Thua < Hòa");
            }
            else
            {
                errorProvider.SetError(groupBox4, null);
            }
        }

        private void MacDichButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đặt lại quy định mặc định!", "Thông Báo");
            DIEUKIEN dk = new DIEUKIEN()
            {
                MaMuaGiai = GlobalState.selectedSeasonId,
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
            Database.DieuKien_DAO.updateDieuKien(dk);
            ThayDoiQuyDinh_Load(this, new EventArgs());
        }
    }
}
