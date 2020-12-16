using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class LoaiCauThu_DAO
    {
        public static void createLoaiCauThu(LOAICAUTHU loaict)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO LOAICAUTHU Values (NEWID(), @TenLoaiCauThu, @CauThuNuocNgoai, @MaMuaGiai)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", loaict.MaMuaGiai);
                command.Parameters.AddWithValue("@TenLoaiCauThu", loaict.TenLoaiCauThu);
                command.Parameters.AddWithValue("@CauThuNuocNgoai", loaict.CauThuNuocNgoai);
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
        public static void updateLoaiCauThu(LOAICAUTHU loaict)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE LOAICAUTHU SET TenLoaiCauThu = @TenLoaiCauThu, CauThuNuocNgoai = @CauThuNuocNgoai WHERE MaLoaiCauThu = @MaLoaiCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaLoaiCauThu", loaict.MaLoaiCauThu);
                command.Parameters.AddWithValue("@TenLoaiCauThu", loaict.TenLoaiCauThu);
                command.Parameters.AddWithValue("@CauThuNuocNgoai", loaict.CauThuNuocNgoai);
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
        public static void selectLoaiCauThu(string MaLoaiCauThu, out LOAICAUTHU loaict)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenLoaiCauThu, MaMuaGiai, CauThuNuocNgoai FROM LOAICAUTHU WHERE MaLoaiCauThu = @MaLoaiCauThu";
            SqlCommand command = new SqlCommand(queryString);
            loaict = new LOAICAUTHU() { MaLoaiCauThu = MaLoaiCauThu };
            try
            {
                command.Parameters.AddWithValue("@MaLoaiCauThu", MaLoaiCauThu);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    loaict.TenLoaiCauThu = reader.GetString(0);
                    loaict.MaMuaGiai = reader.GetString(1);
                    loaict.CauThuNuocNgoai = reader.GetBoolean(3);
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
