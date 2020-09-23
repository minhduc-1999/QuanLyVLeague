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
    public partial class DanhSachCauThu : Form
    {
        private string selectedTeamId = "0";
        public DanhSachCauThu(string selectedTeamId)
        {
            this.selectedTeamId = selectedTeamId;
            InitializeComponent();
        }

        private void DanhSachCauThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.CauThu' table. You can move, or remove it, as needed.
            this.cauThuTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.CauThu);
            cauThuBindingSource.Filter = "MaDoi = '" + selectedTeamId + "' AND NgayRoiDi IS NULL";
        }

        private void themCauThu_Click(object sender, EventArgs e)
        {
            var lst = danhSachCauThuList.SelectedItems.Cast<DataRowView>();
            try
            {
                foreach (var item in lst)
                {
                    String selectedPlayerId = item.Row[0].ToString();
                    Database.DanhSachThamGia_DAO.createDanhSachThamGia(GlobalState.selectedMatchId, selectedPlayerId, false, false);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }

        }
    }
}
