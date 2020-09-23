using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyGiaiVoDich.Database
{
    class LoaiCauThu_DAO
    {
        public static void createLoaiCauThu(string MaMuaGiai, string TenLoaiCauThu, bool CauThuNuocNgoai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO LOAICAUTHU Values (NEWID(), @TenLoaiCauThu, @CauThuNuocNgoai, @MaMuaGiai)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Parameters.AddWithValue("@TenLoaiCauThu", TenLoaiCauThu);
                command.Parameters.AddWithValue("@CauThuNuocNgoai", CauThuNuocNgoai);
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
        public static void removeLoaiCauThu(string MaLoaiCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM LOAICAUTHU WHERE MaLoaiCauThu = @MaLoaiCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaLoaiCauThu", MaLoaiCauThu);
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
        public static void updateLoaiCauThu(string MaLoaiCauThu, string TenLoaiCauThu, bool CauThuNuocNgoai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE LOAICAUTHU SET TenLoaiCauThu = @TenLoaiCauThu, CauThuNuocNgoai = @CauThuNuocNgoai WHERE MaLoaiCauThu = @MaLoaiCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaLoaiCauThu", MaLoaiCauThu);
                command.Parameters.AddWithValue("@TenLoaiCauThu", TenLoaiCauThu);
                command.Parameters.AddWithValue("@CauThuNuocNgoai", CauThuNuocNgoai);
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
        public static void selectLoaiCauThu(string MaLoaiCauThu, out string TenLoaiCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenLoaiCauThu FROM LOAICAUTHU WHERE MaLoaiCauThu = @MaLoaiCauThu";
            SqlCommand command = new SqlCommand(queryString);
            TenLoaiCauThu = "";
            try
            {
                command.Parameters.AddWithValue("@MaLoaiCauThu", MaLoaiCauThu);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TenLoaiCauThu = reader.GetString(0);
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

        public static string queryMaLoaiCauThu(string TenLoaiCauThu, string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaLoaiCauThu FROM LOAICAUTHU WHERE TenLoaiCauThu = @TenLoaiCauThu AND MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            string MaLoaiCauThu = "";
            try
            {
                command.Parameters.AddWithValue("@TenLoaiCauThu", TenLoaiCauThu);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader sqlreader = command.ExecuteReader();
                if (sqlreader.Read())
                {
                    MaLoaiCauThu = sqlreader.GetString(0);
                }
                sqlreader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return MaLoaiCauThu;
        }
    }
}
