using QuanLyGiaiVoDich.DTO_Class.Class;
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
    public partial class ThemSanThiDau : Form
    {
        private DataGridViewRow selectedRow;

        public ThemSanThiDau()
        {
            InitializeComponent();
            tenSanThiDauTextBox.Focus();
        }

        private void ThemSanThiDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.SanThiDauExt' table. You can move, or remove it, as needed.
            this.sanThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauExt);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            muaGiaiComboBox.SelectedValue = GlobalState.selectedSeasonId;
			
			sanThiDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra validate 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    SANTHIDAU santhidau = new SANTHIDAU()
                    {
                        TenSanThiDau = tenSanThiDauTextBox.Text,
                        MaMuaGiai = (string)muaGiaiComboBox.SelectedValue,
                        DonViSoHuu = tenDonViSoHuuTextBox.Text,
                    };
                    Database.SanThiDau_DAO.createSanThiDau(santhidau);
                    xoaSanThiDau.Enabled = false;
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
                this.sanThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauExt);
                this.danhSachSanThiDauData.Update();
            }
        }

        private void TenSanThiDauTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra textBox được nhập hay chưa? 
            if (string.IsNullOrEmpty(tenSanThiDauTextBox.Text))
            {
                e.Cancel = true;
                tenSanThiDauTextBox.Focus();
                errorProvider.SetIconAlignment(tenSanThiDauTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(tenSanThiDauTextBox, "Hãy điền thông tin đầy đủ!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tenSanThiDauTextBox, null);
            }
        }

        private void TenDonViSoHuuTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra textBox được nhập hay chưa? 
            if (string.IsNullOrEmpty(tenDonViSoHuuTextBox.Text))
            {
                e.Cancel = true;
                tenDonViSoHuuTextBox.Focus();
                errorProvider.SetIconAlignment(tenDonViSoHuuTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(tenDonViSoHuuTextBox, "Hãy điền thông tin đầy đủ!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tenDonViSoHuuTextBox, null);
            }
        }

        private void tenSanThiDauTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void danhSachSanThiDauData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedRow = danhSachSanThiDauData.Rows[e.RowIndex];
            xoaSanThiDau.Enabled = true;
        }

        private void xoaSanThiDau_Click(object sender, EventArgs e)
        {
            try
            {
                Database.VongDau_DAO.removeVongDau(selectedRow.Cells[0].Value.ToString());
                selectedRow = null;
                this.sanThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.SanThiDauExt);
                xoaSanThiDau.Enabled = false;
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }

        private void TenDonViSoHuuTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ThemSanThiDau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    try
                    {
                        helper.importHelper.importSanThiDau(ofd.FileName);
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
                sanThiDauExtTableAdapter.Fill(quanLyGiaiVoDichDataSet.SanThiDauExt);
            }
        }
    }
}
