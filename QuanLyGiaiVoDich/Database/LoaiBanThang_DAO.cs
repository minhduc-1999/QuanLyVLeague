using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyGiaiVoDich.Database
{
    class LoaiBanThang_DAO
    {
        public static void createLoaiBanThang(string MaMuaGiai, string TenLoaiBanThang, bool TinhBanChoCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO LOAIBANTHANG Values (NEWID(),@MaMuaGiai,@TenLoaiBanThang,@TinhBanChoCauThu)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@TenLoaiBanThang", TenLoaiBanThang);
                command.Parameters.AddWithValue("@TinhBanChoCauThu", TinhBanChoCauThu);
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
        public static void removeLoaiBanThang (string MaLoaiBanThang)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM LOAIBANTHANG WHERE MaLoaiBanThang = @MaLoaiBanThang";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaLoaiBanThang", MaLoaiBanThang);
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
        public static void updateLoaiBanThang(string MaLoaiBanThang, string TenLoaiBanThang, bool TinhBanChoCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE LOAIBANTHANG SET TenLoaiBanThang = @TenLoaiBanThang, TinhBanChoCauThu = @TinhBanChoCauThu WHERE MaLoaiBanThang = @MaLoaiBanThang";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaLoaiBanThang", MaLoaiBanThang);
                command.Parameters.AddWithValue("@TenLoaiBanThang", TenLoaiBanThang);
                command.Parameters.AddWithValue("@TinhBanChoCauThu", TinhBanChoCauThu);
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
        public static void selectLoaiBanThang(string MaLoaiBanThang, out string MaMuaGiai, out string TenLoaiBanThang, out bool TinhBanChoCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaMuaGiai, TenLoaiBanThang, TinhBanChoCauThu FROM LOAIBANTHANG WHERE MaLoaiBanThang = @MaLoaiBanThang";
            SqlCommand command = new SqlCommand(queryString);
            MaMuaGiai = "";
            TenLoaiBanThang = "";
            TinhBanChoCauThu = false;
            try
            {
                command.Parameters.AddWithValue("@MaLoaiBanThang", MaLoaiBanThang);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MaMuaGiai = reader.GetString(0);
                    TenLoaiBanThang = reader.GetString(1);
                    TinhBanChoCauThu = reader.GetBoolean(2);
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
