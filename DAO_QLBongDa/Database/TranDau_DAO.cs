using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO_QLBongDa.Database
{
    public class TranDau_DAO
    {
        public static void createTranDau(string MaMuaGiai, string DoiChuNha, string DoiKhach, DateTime dtNgayThiDau, DateTime dtNgayThiDauChinh, DateTime dtGioThiDau, DateTime dtGioThiDauChinh, string MaSanThiDau, string MaSanThiDauChinh, int SoBanThangDoiNha, int SoBanThangDoiKhach, TimeSpan dtThoiGianThiDau, string MaVongDau)
        {
            string NgayThiDau = dtNgayThiDau.ToString("yyyy-MM-dd");
            string NgayThiDauChinh = dtNgayThiDauChinh.ToString("yyyy-MM-dd");
            string GioThiDau = dtGioThiDau.ToString("HH:mm:ss");
            string GioThiDauChinh = dtGioThiDauChinh.ToString("HH:mm:ss");
            string ThoiGianThiDau = dtThoiGianThiDau.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO TRANDAU Values (NEWID(),@MaMuaGiai,@DoiChuNha,@DoiKhach,@NgayThiDau,@NgayThiDauChinh,@GioThiDau,@GioThiDauChinh,@MaSanThiDau,@MaSanThiDauChinh,@SoBanThangDoiNha,@SoBanThangDoiKhach,@ThoiGianThiDau,@MaVongDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@DoiChuNha", DoiChuNha);
                command.Parameters.AddWithValue("@DoiKhach", DoiKhach);
                command.Parameters.AddWithValue("@NgayThiDau", NgayThiDau);
                command.Parameters.AddWithValue("@NgayThiDauChinh", NgayThiDauChinh);
                command.Parameters.AddWithValue("@GioThiDau", GioThiDau);
                command.Parameters.AddWithValue("@GioThiDauChinh", GioThiDauChinh);
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Parameters.AddWithValue("@MaSanThiDauChinh", MaSanThiDauChinh);
                command.Parameters.AddWithValue("@SoBanThangDoiNha", SoBanThangDoiNha);
                command.Parameters.AddWithValue("@SoBanThangDoiKhach", SoBanThangDoiKhach);
                command.Parameters.AddWithValue("@ThoiGianThiDau", ThoiGianThiDau);
                command.Parameters.AddWithValue("@MaVongDau", MaVongDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception();
                }
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static void createTranDau(string MaMuaGiai, string DoiChuNha, string DoiKhach, DateTime dtNgayThiDau, DateTime dtGioThiDau, string MaSanThiDau, string MaVongDau)
        {
            //for creating match schedule
            string NgayThiDau = dtNgayThiDau.ToString("yyyy-MM-dd");
            string GioThiDau = dtGioThiDau.ToString("HH:mm:ss");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO TRANDAU(MaTranDau, MaMuaGiai, DoiChuNha, DoiKhach, NgayThiDau, GioThiDau, MaSanThiDau, MaVongDau) Values (NEWID(),@MaMuaGiai,@DoiChuNha,@DoiKhach,@NgayThiDau,@GioThiDau,@MaSanThiDau,@MaVongDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@DoiChuNha", DoiChuNha);
                command.Parameters.AddWithValue("@DoiKhach", DoiKhach);
                command.Parameters.AddWithValue("@NgayThiDau", NgayThiDau);
                command.Parameters.AddWithValue("@GioThiDau", GioThiDau);
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Parameters.AddWithValue("@MaVongDau", MaVongDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception();
                }
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void removeTranDau(string MaTranDau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM TRANDAU WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception();
                }
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void updateTranDau(string MaTranDau, string MaMuaGiai, string DoiChuNha, string DoiKhach, DateTime dtNgayThiDau, DateTime dtNgayThiDauChinh, DateTime dtGioThiDau, DateTime dtGioThiDauChinh,
            string MaSanThiDau, string MaSanThiDauChinh, int SoBanThangDoiNha, int SoBanThangDoiKhach, TimeSpan dtThoiGianThiDau, string MaVongDau)
        {
            string NgayThiDau = dtNgayThiDau.ToString("yyyy-MM-dd");
            string NgayThiDauChinh = dtNgayThiDauChinh.ToString("yyyy-MM-dd");
            string GioThiDau = dtGioThiDau.ToString("HH:mm:ss");
            string GioThiDauChinh = dtGioThiDauChinh.ToString("HH:mm:ss");
            string ThoiGianThiDau = dtThoiGianThiDau.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE TRANDAU SET MaMuaGiai = @MaMuaGiai, DoiChuNha = @DoiChuNha, DoiKhach = @DoiKhach, NgayThiDau = @NgayThiDau, NgayThiDauChinh = @NgayThiDauChinh, GioThiDau = @GioThiDau, GioThiDauChinh = @GioThiDauChinh, MaSanThiDau = @MaSanThiDau, MaSanThiDauChinh = @MaSanThiDauChinh, SoBanThangDoiNha = @SoBanThangDoiNha, SoBanThangDoiKhach = @SoBanThangDoiKhach, ThoiGianThiDau = @ThoiGianThiDau, MaVongDau = @MaVongDau WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@DoiChuNha", DoiChuNha);
                command.Parameters.AddWithValue("@DoiKhach", DoiKhach);
                command.Parameters.AddWithValue("@NgayThiDau", NgayThiDau);
                command.Parameters.AddWithValue("@NgayThiDauChinh", NgayThiDauChinh);
                command.Parameters.AddWithValue("@GioThiDau", GioThiDau);
                command.Parameters.AddWithValue("@GioThiDauChinh", GioThiDauChinh);
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Parameters.AddWithValue("@MaSanThiDauChinh", MaSanThiDauChinh);
                command.Parameters.AddWithValue("@SoBanThangDoiNha", SoBanThangDoiNha);
                command.Parameters.AddWithValue("@SoBanThangDoiKhach", SoBanThangDoiKhach);
                command.Parameters.AddWithValue("@ThoiGianThiDau", ThoiGianThiDau);
                command.Parameters.AddWithValue("@MaVongDau", MaVongDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception();
                }
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void updateTranDau(string MaTranDau, DateTime dtNgayThiDauChinh, DateTime dtGioThiDauChinh,
            string MaSanThiDauChinh, TimeSpan dtThoiGianThiDau, int SoBanThangDoiNha, int SoBanThangDoiKhach)
        {
            string NgayThiDauChinh = dtNgayThiDauChinh.ToString("yyyy-MM-dd");
            string GioThiDauChinh = dtGioThiDauChinh.ToString("HH:mm:ss");
            string ThoiGianThiDau = dtThoiGianThiDau.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE TRANDAU SET NgayThiDauChinh = @NgayThiDauChinh, GioThiDauChinh = @GioThiDauChinh, MaSanThiDauChinh = @MaSanThiDauChinh, ThoiGianThiDau = @ThoiGianThiDau, SoBanThangDoiNha = @SoBanThangDoiNha, SoBanThangDoiKhach = @SoBanThangDoiKhach WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@NgayThiDauChinh", NgayThiDauChinh);
                command.Parameters.AddWithValue("@GioThiDauChinh", GioThiDauChinh);
                command.Parameters.AddWithValue("@MaSanThiDauChinh", MaSanThiDauChinh);
                command.Parameters.AddWithValue("@ThoiGianThiDau", ThoiGianThiDau);
                command.Parameters.AddWithValue("@SoBanThangDoiNha", SoBanThangDoiNha);
                command.Parameters.AddWithValue("@SoBanThangDoiKhach", SoBanThangDoiKhach);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception();
                }
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //BROKEN, DO NOT USE
        public static void selectTranDau(string MaTranDau, out string MaMuaGiai, out string DoiChuNha, out string DoiKhach, out string NgayThiDau, out string NgayThiDauChinh, out string GioThiDau, out string GioThiDauChinh,
            out string MaSanThiDau, out string MaSanThiDauChinh, out int SoBanThangDoiNha, out int SoBanThangDoiKhach, out string ThoiGianThiDau, out string MaVongDau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM TRANDAU WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            MaMuaGiai = "";
            DoiChuNha = "";
            DoiKhach = "";
            NgayThiDau = "";
            NgayThiDauChinh = "";
            GioThiDau = "";
            GioThiDauChinh = "";
            MaSanThiDau = "";
            MaSanThiDauChinh = "";
            SoBanThangDoiNha = 0;
            SoBanThangDoiKhach = 0;
            ThoiGianThiDau = "";
            MaVongDau = "";
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MaMuaGiai = reader.GetString(1);
                    DoiChuNha = reader.GetString(2);
                    DoiKhach = reader.GetString(3);
                    NgayThiDau = Convert.ToDateTime(reader[4]).ToString("yyyy-MM-dd");
                    NgayThiDauChinh = Convert.ToDateTime(reader[5]).ToString("yyyy-MM-dd");
                    GioThiDau = Convert.ToDateTime(reader[6]).ToString("HH-mm-ss");
                    GioThiDauChinh = Convert.ToDateTime(reader[7]).ToString("HH-mm-ss");
                    MaSanThiDau = reader.GetString(8);
                    MaSanThiDauChinh = reader.GetString(9);
                    SoBanThangDoiNha = reader.GetInt32(10);
                    SoBanThangDoiKhach = reader.GetInt32(11);
                    ThoiGianThiDau = Convert.ToDateTime(reader[12]).ToString("HH-mm-ss");
                    MaVongDau = reader.GetString(13);
                }
                reader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void loadThongTinThiDau(string MaTranDau, out string DoiChuNha, out string DoiKhach, out DateTime NgayThiDau, out DateTime GioThiDau, out string MaSanThiDau, out string MaVongDau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM TRANDAU WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            DoiChuNha = "";
            DoiKhach = "";
            NgayThiDau = DateTime.Now;
            GioThiDau = DateTime.Now;
            MaSanThiDau = "";
            MaVongDau = "";
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DoiChuNha = reader.GetString(2);
                    DoiKhach = reader.GetString(3);
                    NgayThiDau = reader.GetDateTime(4);
                    GioThiDau = Convert.ToDateTime(reader.GetTimeSpan(6).ToString());
                    MaSanThiDau = reader.GetString(8);
                    MaVongDau = reader.GetString(13);
                }
                reader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void loadTiSoTranDau(string MaTranDau, out int tiSoDoiNha, out int tiSoDoiKhach)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM TRANDAU WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            tiSoDoiNha = 0;
            tiSoDoiKhach = 0;
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(10)) tiSoDoiNha = reader.GetInt32(10);
                    if (!reader.IsDBNull(11)) tiSoDoiKhach = reader.GetInt32(11);
                }
                reader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool kiemTraTranDauDaDienRa(string MaTranDau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM TRANDAU WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            bool res = false;
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(10)) res = true;
                    else res = false;
                }
                reader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }


        public static TimeSpan loadThoiGianThiDau(string MaTranDau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM TRANDAU WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            TimeSpan thoiGianThiDau = new TimeSpan(0);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(12)) thoiGianThiDau = reader.GetTimeSpan(12);
                }
                reader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return thoiGianThiDau;
        }

        public static List<string> load5TranGanNhat(string MaDoi, string MaMuaGiai)
        {
            List<string> res = new List<String>();
            string[] MaDoiNha = new string[5];
            string[] MaDoiKhach = new string[5];
            string[] TiSo = new string[5];
            int instance_count = 0;
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TOP 5 * FROM TRANDAU WHERE (DoiChuNha = @MaDoi OR DoiKhach = @MaDoi) AND MaMuaGiai = @MaMuaGiai AND SoBanThangDoiNha IS NOT NULL ORDER BY NgayThiDauChinh DESC";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MaDoiNha[instance_count] = reader.GetString(2);
                    MaDoiKhach[instance_count] = reader.GetString(3);
                    TiSo[instance_count] = reader.GetInt32(10) + " - " + reader.GetInt32(11);
                    instance_count++;
                }
                reader.Close();
                for (int i = 0; i < instance_count; i++)
                {
                    res.Add(DoiBong_DAO.queryTenDoiBong(MaDoiNha[i]) + " " + TiSo[i] + " " + DoiBong_DAO.queryTenDoiBong(MaDoiKhach[i]));
                }
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        public static void updateLichThiDau(string MaTranDau, DateTime dtNgayThiDau, DateTime dtGioThiDau, string MaSanThiDau)
        {
            string NgayThiDau = dtNgayThiDau.ToString("yyyy-MM-dd");
            string GioThiDau = dtGioThiDau.ToString("HH:mm:ss");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE TRANDAU SET NgayThiDau = @NgayThiDau, GioThiDau = @GioThiDau, MaSanThiDau = @MaSanThiDau WHERE MaTranDau = @MaTranDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@NgayThiDau", NgayThiDau);
                command.Parameters.AddWithValue("@GioThiDau", GioThiDau);
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception();
                }
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
