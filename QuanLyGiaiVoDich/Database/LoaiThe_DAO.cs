using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class LoaiThe_DAO
    {
        public static void createLoaiThe(LOAITHE loaithe)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO LOAITHE Values (NEWID(), @TenThe)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenThe", loaithe.TenThe);
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
        public static void updateLoaiThe(LOAITHE loaithe)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE LOAITHE SET TenThe = @TenThe WHERE MaLoaiThe = @MaLoaiThe";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenThe", loaithe.TenThe);
                command.Parameters.AddWithValue("@MaLoaiThe", loaithe.MaLoaiThe);
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
        public static void selectLoaiThe(string MaLoaiThe, out LOAITHE loaithe)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenThe FROM LOAITHE WHERE MaLoaiThe = @MaLoaiThe";
            SqlCommand command = new SqlCommand(queryString);
            loaithe = new LOAITHE() { MaLoaiThe = MaLoaiThe };
            try
            {
                command.Parameters.AddWithValue("@MaLoaiThe", MaLoaiThe);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    loaithe.TenThe = reader.GetString(0);
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
