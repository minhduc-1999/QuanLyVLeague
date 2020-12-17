using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database

{
    class VongDau_DAO
    {
        //public static void createVongDau(string TenVongDau, string MaMuaGiai)
        public static void createVongDau(VONGDAU vongdau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO VONGDAU Values (NEWID(),@TenVongDau,@MaMuaGiai)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", vongdau.MaMuaGiai);
                command.Parameters.AddWithValue("@TenVongDau", vongdau.TenVongDau);
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
        public static void updateVongDau(VONGDAU vongdau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE VONGDAU SET TenVongDau = @TenVongDau, MaMuaGiai = @MaMuaGiai WHERE MaVongDau = @MaVongDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", vongdau.MaMuaGiai);
                command.Parameters.AddWithValue("@TenVongDau", vongdau.TenVongDau);
                command.Parameters.AddWithValue("@MaVongDau", vongdau.MaVongDau);
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
        public static void selectVongDau(string MaVongDau, out VONGDAU vongdau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenVongDau, MaMuaGiai FROM VONGDAU WHERE MaVongDau = @MaVongDau";
            SqlCommand command = new SqlCommand(queryString);
            vongdau = new VONGDAU()
            {
                TenVongDau = "",
                MaMuaGiai = "",
            };
            try
            {
                command.Parameters.AddWithValue("@MaVongDau", MaVongDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    vongdau.TenVongDau = reader.GetString(0);
                    vongdau.MaMuaGiai = reader.GetString(1);
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
        public static string queryMaVongDau(VONGDAU vongdau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaVongDau FROM VONGDAU WHERE TenVongDau = @TenVongDau AND MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            string result = "";
            try
            {
                command.Parameters.AddWithValue("@TenVongDau", vongdau.TenVongDau);
                command.Parameters.AddWithValue("@MaMuaGiai", vongdau.MaMuaGiai);
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
