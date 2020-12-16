using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyGiaiVoDich.Database
{
    public class PhatThe_DAO
    {
        public static void createPhatThe(string MaCauThu, string MaLoaiThe, TimeSpan dtThoiDiem, string MaTranDau)
        {
            string ThoiDiem = dtThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            
            string queryString = "INSERT INTO PHATTHE Values (NEWID(), @MaCauThu, @MaLoaiThe, @ThoiDiem, @MaTranDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiThe", MaLoaiThe);
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
        public static void removePhatThe(string MaPhatThe)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM PHATTHE WHERE MaPhatThe = @MaPhatThe";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaPhatThe", MaPhatThe);
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
        public static void updatePhatThe(string MaPhatThe, string MaCauThu, string MaLoaiThe, TimeSpan dtThoiDiem, string MaTranDau)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string ThoiDiem = dtThoiDiem.ToString("c");
            string queryString = "UPDATE PHATTHE SET MaCauThu = @MaCauThu, MaLoaiThe = @MaLoaiThe, ThoiDiem = @ThoiDiem, MaTranDau = @MaTranDau WHERE MaPhatThe = @MaPhatThe";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiThe", MaLoaiThe);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaPhatThe", MaPhatThe);
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
        public static void selectPhatThe(string MaPhatThe, out string MaCauThu, out string MaLoaiThe, out TimeSpan ThoiDiem)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM PHATTHE WHERE MaPhatThe = @MaPhatThe";
            SqlCommand command = new SqlCommand(queryString);
            MaCauThu = "";
            MaLoaiThe = "";
            ThoiDiem = new TimeSpan(0);
            try
            {
                command.Parameters.AddWithValue("@MaPhatThe", MaPhatThe);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MaCauThu = reader.GetString(1);
                    MaLoaiThe = reader.GetString(2);
                    ThoiDiem = reader.GetTimeSpan(3);
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
