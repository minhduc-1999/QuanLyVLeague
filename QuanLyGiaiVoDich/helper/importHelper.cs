using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiVoDich.helper
{
    class importHelper
    {
        public static void importSanThiDau(string filename)
        {
            Encoding encoding = Encoding.UTF8;
            string output = File.ReadAllText(filename, encoding);
            string[] lineSeparators = new string[] { "\n" };
            List<string> lines = new List<string>(output.Split(lineSeparators, StringSplitOptions.RemoveEmptyEntries));

            bool ignoreHeader = true;
            foreach (string line in lines)
            {
                if (ignoreHeader)
                {
                    ignoreHeader = false;
                    continue;
                }
                string[] compSeparators = new string[] { "," };
                string[] component = line.Split(compSeparators, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Database.SanThiDau_DAO.createSanThiDau(component[0], GlobalState.selectedSeasonId, component[1]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tại {" + line.Trim() + "} xảy ra lỗi: " + ex.Message, "Lỗi xảy ra");
                }
            }
        }

        public static void importVongDau(string filename)
        {
            Encoding encoding = Encoding.UTF8;
            string output = File.ReadAllText(filename, encoding);
            string[] stringSeparators = new string[] { "\n" };
            List<string> lines = new List<string>(output.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries));
            
            bool ignoreHeader = true;
            foreach (string line in lines)
            {
                if (ignoreHeader)
                {
                    ignoreHeader = false;
                    continue;
                }
                try
                {
                    Database.VongDau_DAO.createVongDau(line.Trim(), GlobalState.selectedSeasonId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tại {" + line.Trim() + "} xảy ra lỗi: " + ex.Message, "Lỗi xảy ra");
                }
            }
        }

        public static void importHoSoDoiBong(string filename, ref DataGridView cauThuData, ref TextBox tenDoi, ref ComboBox sanNha)
        {
            Encoding encoding = Encoding.UTF8;
            string output = File.ReadAllText(filename, encoding);
            string[] stringSeparators = new string[] { "\n" };
            List<string> lines = new List<string>(output.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries));

            bool teamNameField = true;
            bool teamStadiumField = true;
            bool playerHeader = true;

            foreach (string line in lines)
            {
                string[] compSeparators = new string[] { "," };
                string[] component = line.Trim().Split(compSeparators, StringSplitOptions.RemoveEmptyEntries);
                if (teamNameField) { 
                    try
                    {
                        tenDoi.Text = component[1];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xảy ra khi đọc trường tên đội: " + ex.Message, "Lỗi xảy ra");
                    }
                    teamNameField = false; 
                    continue; 
                }
                if (teamStadiumField) {
                    try
                    {
                        sanNha.SelectedValue = Database.SanThiDau_DAO.queryMaSanThiDau(component[1], GlobalState.selectedSeasonId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xảy ra khi đọc trường tên sân nhà: " + ex.Message, "Lỗi xảy ra");
                    }
                    teamStadiumField = false; 
                    continue; 
                }
                if (playerHeader) { playerHeader = false; continue; }
                try
                {
                    //add player to datagridview
                    if (Database.LoaiCauThu_DAO.queryMaLoaiCauThu(component[3], GlobalState.selectedSeasonId).Equals("")) throw new Exception("Loại cầu thủ không tồn tại");
                    String[] row = { (cauThuData.Rows.Count + 1).ToString(), component[0].ToString(), Guid.NewGuid().ToString(), component[1], DateTime.Parse(component[2]).ToString(), component[3], component[4] };
                    cauThuData.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tại {" + line.Trim() + "} xảy ra lỗi: " + ex.Message, "Lỗi xảy ra");
                }
            }
        }

        public static void importLichThiDau(string filename)
        {
            Encoding encoding = Encoding.UTF8;
            string output = File.ReadAllText(filename, encoding);
            string[] stringSeparators = new string[] { "\n" };
            List<string> lines = new List<string>(output.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries));

            bool ignoreHeader = true;
            foreach (string line in lines)
            {
                string[] compSeparators = new string[] { "," };
                string[] component = line.Trim().Split(compSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (ignoreHeader)
                {
                    ignoreHeader = false;
                    continue;
                }

                try
                {
                    string maVongDau = Database.VongDau_DAO.queryMaVongDau(component[0], GlobalState.selectedSeasonId);
                    if (maVongDau.Equals("")) throw new Exception("Vòng đấu không tồn tại");
                    string maDoiNha = Database.DoiBong_DAO.queryMaDoiBong(component[1], GlobalState.selectedSeasonId);
                    if (maDoiNha.Equals("")) throw new Exception("Đội bóng không tồn tại");
                    string maDoiKhach = Database.DoiBong_DAO.queryMaDoiBong(component[2], GlobalState.selectedSeasonId);
                    if (maDoiKhach.Equals("")) throw new Exception("Đội bóng không tồn tại");
                    string maSanThiDau = Database.SanThiDau_DAO.queryMaSanThiDau(component[5], GlobalState.selectedSeasonId);
                    if (maSanThiDau.Equals("")) throw new Exception("Sân thi đấu không tồn tại");

                    Database.TranDau_DAO.createTranDau(GlobalState.selectedSeasonId, maDoiNha, maDoiKhach, DateTime.Parse(component[3]), DateTime.Parse(component[4]), maSanThiDau, maVongDau);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tại {" + line.Trim() + "} xảy ra lỗi: " + ex.Message, "Lỗi xảy ra");
                }
            }
        }
    }
}
