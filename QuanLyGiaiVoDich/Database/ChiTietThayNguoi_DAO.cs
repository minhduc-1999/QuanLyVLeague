using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class ChiTietThayNguoi_DAO
    {
        public static void createChiTietThayNguoi(CHITIETTHAYNGUOI thaynguoi)
        {
            string ThoiDiem = thaynguoi.ThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO CHITIETTHAYNGUOI Values (NEWID(), @MaCauThuVaoSan, @MaCauThuRaSan, @ThoiDiem, @MaTranDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThuVaoSan", thaynguoi.MaCauThuVaoSan);
                command.Parameters.AddWithValue("@MaCauThuRaSan", thaynguoi.MaCauThuRaSan);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", thaynguoi.MaTranDau);
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
        public static void removeChiTietThayNguoi(string MaThayNguoi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM CHITIETTHAYNGUOI WHERE MaThayNguoi = @MaThayNguoi";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaThayNguoi", MaThayNguoi);
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
        public static void updateChiTietThayNguoi(CHITIETTHAYNGUOI thaynguoi)
        {
            string ThoiDiem = thaynguoi.ThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE CHITIETTHAYNGUOI SET MaCauThuVaoSan = @MaCauThuVaoSan, MaCauThuRaSan = @MaCauThuRaSan, ThoiDiem = @ThoiDiem, MaTranDau = @MaTranDau WHERE MaThayNguoi = @MaThayNguoi";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaThayNguoi", thaynguoi.MaThayNguoi);
                command.Parameters.AddWithValue("@MaCauThuVaoSan", thaynguoi.MaCauThuVaoSan);
                command.Parameters.AddWithValue("@MaCauThuRaSan", thaynguoi.MaCauThuRaSan);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", thaynguoi.MaTranDau);
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
        public static void selectChiTietThayNguoi(string MaThayNguoi, out CHITIETTHAYNGUOI thaynguoi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaCauThuVaoSan, MaCauThuRaSan, ThoiDiem FROM CHITIETTHAYNGUOI WHERE MaThayNguoi = @MaThayNguoi";
            SqlCommand command = new SqlCommand(queryString);
            thaynguoi = new CHITIETTHAYNGUOI()
            {
                MaThayNguoi = MaThayNguoi
            
            };
            try
            {
                command.Parameters.AddWithValue("@MaThayNguoi", MaThayNguoi);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    thaynguoi.MaCauThuVaoSan = reader.GetString(0);
                    thaynguoi.MaCauThuRaSan = reader.GetString(1);
                    thaynguoi.ThoiDiem = reader.GetTimeSpan(2);
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
