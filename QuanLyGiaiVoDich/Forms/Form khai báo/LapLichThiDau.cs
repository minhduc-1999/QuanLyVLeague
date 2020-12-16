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
    public partial class LapLichThiDau : Form
    {
        private DataGridViewRow selectedRow;

        public LapLichThiDau()
        {
            InitializeComponent();
            doChuNhaComboBox.Focus();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            KhoiTaoVongDau form = new KhoiTaoVongDau();
            form.ShowDialog();
        }

        private void LapLichThiDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.LichThiDauExt' table. You can move, or remove it, as needed.
            this.lichThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LichThiDauExt);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.SanThiDauAllowNull' table. You can move, or remove it, as needed.
            this.sanThiDauAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauAllowNull);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.DoiBong' table. You can move, or remove it, as needed.
            this.doiBongTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DoiBong);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.VongDau' table. You can move, or remove it, as needed.
            this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);

            muaGiaiComboBox.SelectedValue = GlobalState.selectedSeasonId;
            lichThiDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            doiBongBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            doiBongBindingSource1.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
            sanThiDauAllowNullBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
        }

        private void doChuNhaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: automatically update stadium to selected team's home stadium
            try
            {
                sanThiDauComboBox.SelectedValue = DAO_QLBongDa.Database.SanThiDau_DAO.queryMaSanNha(doChuNhaComboBox.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                sanThiDauComboBox.SelectedValue = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //save match schedule
                try
                {
                    DAO_QLBongDa.Database.TranDau_DAO.createTranDau(GlobalState.selectedSeasonId, doChuNhaComboBox.SelectedValue.ToString(), doiKhachComboBox.SelectedValue.ToString(), ngayThiDauPicker.Value, gioThiDauPicker.Value, sanThiDauComboBox.SelectedValue.ToString(), vongThiDauComboBox.SelectedValue.ToString());
                    button1.Enabled = false;
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.lichThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LichThiDauExt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedRow = dataGridView1.Rows[e.RowIndex];
            button1.Enabled = true;
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            //button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAO_QLBongDa.Database.TranDau_DAO.kiemTraTranDauDaDienRa(selectedRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Bạn không thể xóa trận đấu đã diễn ra", "Thông báo");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu lịch thi đấu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //TODO: check if match has been processed
                    DAO_QLBongDa.Database.TranDau_DAO.removeTranDau(selectedRow.Cells[0].Value.ToString());
                    selectedRow = null;
                    this.lichThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LichThiDauExt);
                    button1.Enabled = false;
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private int compareDateTime(DateTime date1, DateTime date2)
        {
            int value = DateTime.Compare(date1, date2);
            return value;
        }


        private void ngayThiDauPicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateMatch = ngayThiDauPicker.Value.Date;
            DateTime now = DateTime.Now.Date;

            int compareValue = compareDateTime(now, dateMatch);

            if (compareValue > 0)
            {
                //e.Cancel = true;

                //ngayPicker.Focus();
                errorProvider.SetIconAlignment(ngayThiDauPicker, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(ngayThiDauPicker, "Đã quá hạn thời gian!");

            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(ngayThiDauPicker, null);
            }
        }

        private void sanThiDauComboBox_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra comboBox được chọn hay chưa? 
            if (sanThiDauComboBox.SelectedValue == null || sanThiDauComboBox.SelectedValue.ToString().Equals("0"))
            {
                e.Cancel = true;
                errorProvider.SetIconAlignment(sanThiDauComboBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(sanThiDauComboBox, "Hãy chọn sân đấu phù hợp!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(sanThiDauComboBox, null);
            }
        }

        private void LapLichThiDau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
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
                        helper.importHelper.importLichThiDau(ofd.FileName);
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
                lichThiDauExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.LichThiDauExt);
            }
        }
    }
}
