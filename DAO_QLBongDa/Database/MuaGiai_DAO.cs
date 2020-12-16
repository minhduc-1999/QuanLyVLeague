using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO_QLBongDa.Database
{
    public class MuaGiai_DAO
    {
        public static void createMuaGiai(string TenMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO MUAGIAI Values (NEWID(), @TenMuaGiai, @TrangThai)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenMuaGiai", TenMuaGiai);
                command.Parameters.AddWithValue("@TrangThai", 0);
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
        public static void removeMuaGiai(string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM MUAGIAI WHERE MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
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
        public static void updateMuaGiai(string MaMuaGiai, string TenMuaGiai, int TrangThai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE MUAGIAI SET TenMuaGiai = @TenMuaGiai, TrangThai = @TrangThai WHERE MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenMuaGiai", TenMuaGiai);
                command.Parameters.AddWithValue("@TrangThai", TrangThai);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
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
        public static void selectMuaGiai(string MaMuaGiai, out string TenMuaGiai, out int TrangThai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenMuaGiai, TrangThai FROM MUAGIAI WHERE MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            TenMuaGiai = "";
            TrangThai = 0;
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TenMuaGiai = reader.GetString(0);
                    TrangThai = reader.GetInt32(1);
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

        public static string queryMaMuaGiai(string TenMuaGiai, int TrangThai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaMuaGiai FROM MUAGIAI WHERE TenMuaGiai = @TenMuaGiai AND TrangThai = @TrangThai";
            SqlCommand command = new SqlCommand(queryString);
            string result = "";
            try
            {
                command.Parameters.AddWithValue("@TenMuaGiai", TenMuaGiai);
                command.Parameters.AddWithValue("@TrangThai", TrangThai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetString(0);
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
