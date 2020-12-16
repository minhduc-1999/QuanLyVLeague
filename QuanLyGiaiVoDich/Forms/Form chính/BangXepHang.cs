using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DTO_QLBongDa.helper;

namespace QuanLyGiaiVoDich
{
    public partial class BangXepHang : Form
    {
        public BangXepHang()
        {
            InitializeComponent();
        }

        private void BangXepHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.BangXepHangExt' table. You can move, or remove it, as needed.
            this.bangXepHangExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.BangXepHangExt);

            muaGiaiComboBox.SelectedValue = GlobalState.selectedSeasonId;
            DialogResult res = MessageBox.Show("Bạn có muốn thực hiện lưu kết quả hiện tại thành bảng xếp hạng của ngày hôm nay?", "Lưu kết quả", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    DAO_QLBongDa.Database.BangXepHang_DAO.updateBXH(GlobalState.selectedSeasonId);
                    this.bangXepHangExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.BangXepHangExt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
            DateTime filterDate = thoiGianPicker.Value;
            this.bangXepHangExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' AND Ngay = #" + filterDate.ToString("yyyy-MM-dd") + "#";
            this.bangXepHangExtBindingSource.Sort = "XepHang asc";

            List<string> MaDoiDongHang = new List<string>();
            int origin_place = 0;

            //Check for team with same rank number and try to apply tiebreaker
            for (int i = 0; i < bangXepHangData.Rows.Count; i++)
            {
                if (MaDoiDongHang.Count == 0)
                {
                    MaDoiDongHang.Add(bangXepHangData.Rows[i].Cells[8].Value.ToString());
                    origin_place = Int16.Parse(bangXepHangData.Rows[i].Cells[0].Value.ToString());
                }
                if (i == 0) continue;
                //prevent out of range indexing
                if (bangXepHangData.Rows[i].Cells[0].Value.ToString().Equals(bangXepHangData.Rows[i-1].Cells[0].Value.ToString()))
                {
                    MaDoiDongHang.Add(bangXepHangData.Rows[i].Cells[8].Value.ToString());
                }
                else
                {
                    if (MaDoiDongHang.Count >= 2)
                    {
                        //if there are more than 2 team with the same ranking, try to resolve using tiebreaker rule, outputting their respective leaderboard priority
                        List<MutablePair<String, int>> tbRes = DAO_QLBongDa.Database.BangXepHang_DAO.tieBreaker(MaDoiDongHang);
                        //iterate through the list, if one's priority value is different from the one above it, update its rank according to the first previously same-rank entry's current rank
                        int current_pr = -1;
                        int current_place = origin_place;
                        for (int j = 0; j < tbRes.Count; j++)
                        {
                            if (current_pr != tbRes[j].Second)
                            {
                                current_pr = tbRes[j].Second;
                                current_place = origin_place + j;
                            }
                            DAO_QLBongDa.Database.BangXepHang_DAO.updateXepHang(tbRes[j].First, thoiGianPicker.Value, current_place);
                        }
                    }
                    MaDoiDongHang.Clear();
                }
                //if we reached the end of the leaderboard, resolve whatever left in the same-rank list
                if (i == bangXepHangData.Rows.Count)
                {
                    if (MaDoiDongHang.Count >= 2)
                    {
                        //if there are more than 2 team with the same ranking, try to resolve using tiebreaker rule, outputting their respective leaderboard priority
                        List<MutablePair<String, int>> tbRes = DAO_QLBongDa.Database.BangXepHang_DAO.tieBreaker(MaDoiDongHang);
                        //iterate through the list, if one's priority value is different from the one above it, update its rank according to the first previously same-rank entry's current rank
                        int current_pr = -1;
                        int current_place = origin_place;
                        for (int j = 0; j < tbRes.Count; j++)
                        {
                            if (current_pr != tbRes[j].Second)
                            {
                                current_pr = tbRes[j].Second;
                                current_place = origin_place + j;
                            }
                            DAO_QLBongDa.Database.BangXepHang_DAO.updateXepHang(tbRes[j].First, thoiGianPicker.Value, current_place);
                        }
                    }
                    MaDoiDongHang.Clear();
                }
            }
            this.bangXepHangExtTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.BangXepHangExt);
            foreach (DataGridViewColumn column in bangXepHangData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void thoiGianPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime filterDate = thoiGianPicker.Value;
            this.bangXepHangExtBindingSource.Filter = "MaMuaGiai = '" + GlobalState.selectedSeasonId + "' AND Ngay = #" + filterDate.ToString("yyyy-MM-dd") + "#";
        }

        private void xuatBXH_Click(object sender, EventArgs e)
        {
            if (bangXepHangData.Rows.Count > 0)
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
                            MessageBox.Show("Không thể chỉnh sửa nội dung file", "Lỗi xảy ra");
                        }
                    }
                    if (!fileError)
                    {
                        helper.exportHelper.exportToPDF(bangXepHangData, sfd.FileName);
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
