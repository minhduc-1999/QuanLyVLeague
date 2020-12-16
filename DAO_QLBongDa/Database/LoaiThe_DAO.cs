using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyGiaiVoDich.Database
{
    public class LoaiThe_DAO
    {
        public static void createLoaiThe(string TenThe, string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO LOAITHE Values (NEWID(), @TenThe, @MaMuaGiai)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenThe", TenThe);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
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
        public static void removeLoaiThe(string MaLoaiThe)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM LOAITHE WHERE MaLoaiThe = @MaLoaiThe";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaLoaiThe", MaLoaiThe);
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
        public static void updateLoaiThe(string MaLoaiThe, string TenThe, string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE LOAITHE SET TenThe = @TenThe, MaMuaGiai = @MaMuaGiai WHERE MaLoaiThe = @MaLoaiThe";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenThe", TenThe);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@MaLoaiThe", MaLoaiThe);
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
        public static void selectLoaiThe(string MaLoaiThe, out string TenThe, out string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenThe, MaMuaGiai FROM LOAITHE WHERE MaLoaiThe = @MaLoaiThe";
            SqlCommand command = new SqlCommand(queryString);
            TenThe = "";
            MaMuaGiai = "";
            try
            {
                command.Parameters.AddWithValue("@MaLoaiThe", MaLoaiThe);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TenThe = reader.GetString(0);
                    MaMuaGiai = reader.GetString(1);    
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
