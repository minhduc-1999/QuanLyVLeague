using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyGiaiVoDich.Database
{
    public class BanThang_DAO
    {
        public static void createBanThang(string MaCauThu, string MaLoaiBanThang, TimeSpan dtThoiDiem, string MaTranDau)
        {
            string ThoiDiem = dtThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO BANTHANG Values (NEWID(),@MaCauThu,@MaLoaiBanThang,@ThoiDiem,@MaTranDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiBanThang", MaLoaiBanThang);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot insert New Goal!");
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
        public static void removeBanThang(string MaBanThang)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM BANTHANG WHERE MaBanThang = @MaBanThang";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaBanThang", MaBanThang);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot remove Goal!");
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
        public static void updateBanThang(string MaBanThang, string MaCauThu, string MaLoaiBanThang, TimeSpan dtThoiDiem, string MaTranDau)
        {
            string ThoiDiem = dtThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE BANTHANG SET MaCauThu = @MaCauThu, MaLoaiBanThang = @MaLoaiBanThang, ThoiDiem = @ThoiDiem, MaTranDau = @MaTranDau WHERE MaBanThang = @MaBanThang";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiBanThang", MaLoaiBanThang);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaBanThang", MaBanThang);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot update Goal!");
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
        public static void selectBanThang(string MaBanThang, out string MaCauThu, out string MaLoaiBanThang, out TimeSpan ThoiDiem)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            
            string queryString = "SELECT MaCauThu, MaLoaiBanThang, ThoiDiem FROM BANTHANG WHERE MaBanThang = @MaBanThang";
            SqlCommand command = new SqlCommand(queryString);
            MaCauThu = "";
            MaLoaiBanThang = "";
            ThoiDiem = new TimeSpan(0);
            try
            {
                command.Parameters.AddWithValue("@MaBanThang", MaBanThang);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MaCauThu = reader.GetString(0);
                    MaLoaiBanThang = reader.GetString(1);
                    ThoiDiem = reader.GetTimeSpan(2);
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
    }
}
