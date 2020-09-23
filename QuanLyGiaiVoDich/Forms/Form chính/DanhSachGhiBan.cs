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
    public partial class DanhSachGhiBan : Form
    {
        public DanhSachGhiBan()
        {
            InitializeComponent();
        }

        private void DanhSachGhiBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.CauThuExt' table. You can move, or remove it, as needed.
            this.cauThuExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.CauThuExt);

            muaGiaiComboBox.SelectedValue = GlobalState.selectedSeasonId;
            this.cauThuExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' AND SoBanThang >= 1";
            this.cauThuExtBindingSource.Sort = "SoBanThang desc";

            int i = 1;
            foreach (DataGridViewRow entry in danhSachGhiBanData.Rows)
            {
                entry.Cells[0].Value = i.ToString();
                i++;
            }

            foreach (DataGridViewColumn column in danhSachGhiBanData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void xuatGhiBan_Click(object sender, EventArgs e)
        {
            if (danhSachGhiBanData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Report.pdf";
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
                            MessageBox.Show("Không thể lưu trên bộ nhớ này: " + ex.Message, "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToPDF(danhSachGhiBanData, sfd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo");
            }
        }
    }
}
