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
    public partial class KhoiTaoVongDau : Form
    {
        private DataGridViewRow selectedRow;

        public KhoiTaoVongDau()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KhoiTaoVongDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.VongDau' table. You can move, or remove it, as needed.
            this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);

            muaGiaiComboBox.SelectedValue = GlobalState.selectedSeasonId;
            vongDauBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'"; 
        }

        private void themVongDau_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (tenVongDauTextBox.Text == "")
                {
                    MessageBox.Show("Hãy đặt tên cho vòng đấu!");
                }
                else
                {
                    try
                    {
                        DAO_QLBongDa.Database.VongDau_DAO.createVongDau(tenVongDauTextBox.Text, (string)muaGiaiComboBox.SelectedValue);
                        tenVongDauTextBox.Text = "";
                        xoaVongDau.Enabled = false;
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi xảy ra");
                    }
                    this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);
                }
                 
            }
            
        }

        private void TenVongDauTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tenVongDauTextBox.Text))
            {
                //e.Cancel = true;
                //tenVongDauTextBox.Focus();
                errorProvider.SetIconAlignment(tenVongDauTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(tenVongDauTextBox, "Hãy điền đầy đủ thông tin!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tenVongDauTextBox, null);
            }
        }

        private void xoaVongDau_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu vòng đấu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DAO_QLBongDa.Database.VongDau_DAO.removeVongDau(selectedRow.Cells[0].Value.ToString());
                    selectedRow = null;
                    this.vongDauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VongDau);
                    xoaVongDau.Enabled = false;
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
    }

        private void danhSachVongDauData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            xoaVongDau.Enabled = true;
            xoaVongDau.Focus();
            selectedRow = danhSachVongDauData.Rows[e.RowIndex];
        }

        private void danhSachVongDauData_Leave(object sender, EventArgs e)
        {
            //xoaVongDau.Enabled = false;
        }

        private void TenVongDauTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                themVongDau_Click(this, new EventArgs());
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    try
                    {
                        helper.importHelper.importVongDau(ofd.FileName);
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
                vongDauTableAdapter.Fill(quanLyGiaiVoDichDataSet.VongDau);
            }
        }
    }
}
