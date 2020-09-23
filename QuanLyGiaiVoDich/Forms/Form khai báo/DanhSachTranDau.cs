using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiVoDich.Forms.Form_khai_báo
{
    public partial class DanhSachTranDau : Form
    {
        private string selectedRoundId; 
        public DanhSachTranDau(string roundId)
        {
            selectedRoundId = roundId;
            InitializeComponent();
        }

        private void DanhSachTranDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.LichThiDauExt' table. You can move, or remove it, as needed.
            this.lichThiDauExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LichThiDauExt);
            lichThiDauExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' AND MaVongDau = '" + this.selectedRoundId + "'";
        }

        private void danhSachTranDauData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (danhSachTranDauData.CurrentRow.Index < 0) return;
            GlobalState.selectedMatchId = danhSachTranDauData.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
