using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class LoaiBanThang_DAO
    {
        public static void createLoaiBanThang(LOAIBANTHANG loaibt)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO LOAIBANTHANG Values (NEWID(),@MaMuaGiai,@TenLoaiBanThang,@TinhBanChoCauThu)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", loaibt.MaMuaGiai);
                command.Parameters.AddWithValue("@TenLoaiBanThang", loaibt.TenLoaiBanThang);
                command.Parameters.AddWithValue("@TinhBanChoCauThu", loaibt.TinhBanChoCauThu);
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
        public static void updateLoaiBanThang(LOAIBANTHANG loaibt)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE LOAIBANTHANG SET TenLoaiBanThang = @TenLoaiBanThang, TinhBanChoCauThu = @TinhBanChoCauThu WHERE MaLoaiBanThang = @MaLoaiBanThang";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaLoaiBanThang", loaibt.MaLoaiBanThang);
                command.Parameters.AddWithValue("@TenLoaiBanThang", loaibt.TenLoaiBanThang);
                command.Parameters.AddWithValue("@TinhBanChoCauThu", loaibt.TinhBanChoCauThu);
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
        public static void selectLoaiBanThang(string MaLoaiBanThang, out LOAIBANTHANG loaibt)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaMuaGiai, TenLoaiBanThang, TinhBanChoCauThu FROM LOAIBANTHANG WHERE MaLoaiBanThang = @MaLoaiBanThang";
            SqlCommand command = new SqlCommand(queryString);
            loaibt = new LOAIBANTHANG() { MaLoaiBanThang = MaLoaiBanThang };
            try
            {
                command.Parameters.AddWithValue("@MaLoaiBanThang", MaLoaiBanThang);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    loaibt.MaMuaGiai = reader.GetString(0);
                    loaibt.TenLoaiBanThang = reader.GetString(1);
                    loaibt.TinhBanChoCauThu = reader.GetBoolean(2);
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
