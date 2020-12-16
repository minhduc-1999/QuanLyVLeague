using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO_QLBongDa.Database
{
    public class VongDau_DAO
    {
        public static void createVongDau(string TenVongDau, string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO VONGDAU Values (NEWID(),@TenVongDau,@MaMuaGiai)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@TenVongDau", TenVongDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot insert New Round!");
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
        public static void removeVongDau(string MaVongDau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM VONGDAU WHERE MaVongDau = @MaVongDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaVongDau", MaVongDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot remove Round!");
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
        public static void updateVongDau(string MaVongDau, string TenVongDau, string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE VONGDAU SET TenVongDau = @TenVongDau, MaMuaGiai = @MaMuaGiai WHERE MaVongDau = @MaVongDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@TenVongDau", TenVongDau);
                command.Parameters.AddWithValue("@MaVongDau", MaVongDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot update Round!");
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
        public static void selectVongDau(string MaVongDau, out string TenVongDau, out string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenVongDau, MaMuaGiai FROM VONGDAU WHERE MaVongDau = @MaVongDau";
            SqlCommand command = new SqlCommand(queryString);
            TenVongDau = "";
            MaMuaGiai = "";
            try
            {
                command.Parameters.AddWithValue("@MaVongDau", MaVongDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TenVongDau = reader.GetString(0);
                    MaMuaGiai = reader.GetString(1);
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

        public static string queryMaVongDau(string TenVongDau, string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaVongDau FROM VONGDAU WHERE TenVongDau = @TenVongDau AND MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            string result = "";
            try
            {
                command.Parameters.AddWithValue("@TenVongDau", TenVongDau);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0)) result = reader.GetString(0);
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
            return result;
        }
    }
}
