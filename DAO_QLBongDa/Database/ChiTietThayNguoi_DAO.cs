using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO_QLBongDa.Database
{
    public class ChiTietThayNguoi_DAO
    {
        public static void createChiTietThayNguoi(string MaCauThuVaoSan, string MaCauThuRaSan, TimeSpan dtThoiDiem, string MaTranDau)
        {
            string ThoiDiem = dtThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO CHITIETTHAYNGUOI Values (NEWID(), @MaCauThuVaoSan, @MaCauThuRaSan, @ThoiDiem, @MaTranDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThuVaoSan", MaCauThuVaoSan);
                command.Parameters.AddWithValue("@MaCauThuRaSan", MaCauThuRaSan);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
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
        public static void updateChiTietThayNguoi(string MaThayNguoi, string MaCauThuVaoSan, string MaCauThuRaSan, TimeSpan dtThoiDiem, string MaTranDau)
        {
            string ThoiDiem = dtThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE CHITIETTHAYNGUOI SET MaCauThuVaoSan = @MaCauThuVaoSan, MaCauThuRaSan = @MaCauThuRaSan, ThoiDiem = @ThoiDiem, MaTranDau = @MaTranDau WHERE MaThayNguoi = @MaThayNguoi";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaThayNguoi", MaThayNguoi);
                command.Parameters.AddWithValue("@MaCauThuVaoSan", MaCauThuVaoSan);
                command.Parameters.AddWithValue("@MaCauThuRaSan", MaCauThuRaSan);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
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
        public static void selectChiTietThayNguoi(string MaThayNguoi, out string MaCauThuVaoSan, out string MaCauThuRaSan, out TimeSpan ThoiDiem)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaCauThuVaoSan, MaCauThuRaSan, ThoiDiem FROM CHITIETTHAYNGUOI WHERE MaThayNguoi = @MaThayNguoi";
            SqlCommand command = new SqlCommand(queryString);
            MaCauThuVaoSan = "";
            MaCauThuRaSan = "";
            ThoiDiem = new TimeSpan(0);
            try
            {
                command.Parameters.AddWithValue("@MaThayNguoi", MaThayNguoi);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MaCauThuVaoSan = reader.GetString(0);
                    MaCauThuRaSan = reader.GetString(1);
                    ThoiDiem = reader.GetTimeSpan(2);
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
