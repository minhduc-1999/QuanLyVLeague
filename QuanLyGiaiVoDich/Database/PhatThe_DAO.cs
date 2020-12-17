using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class PhatThe_DAO
    {
        public static void createPhatThe(PHATTHE phatthe)
        {
            string ThoiDiem = phatthe.ThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            
            string queryString = "INSERT INTO PHATTHE Values (NEWID(), @MaCauThu, @MaLoaiThe, @ThoiDiem, @MaTranDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", phatthe.MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiThe", phatthe.MaLoaiThe);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", phatthe.MaTranDau);
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
        public static void updatePhatThe(PHATTHE phatthe)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string ThoiDiem = phatthe.ThoiDiem.ToString("c");
            string queryString = "UPDATE PHATTHE SET MaCauThu = @MaCauThu, MaLoaiThe = @MaLoaiThe, ThoiDiem = @ThoiDiem, MaTranDau = @MaTranDau WHERE MaPhatThe = @MaPhatThe";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", phatthe.MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiThe", phatthe.MaLoaiThe);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", phatthe.MaTranDau);
                command.Parameters.AddWithValue("@MaPhatThe", phatthe.MaPhatThe);
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
        public static void selectPhatThe(string MaPhatThe, out PHATTHE phatthe)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM PHATTHE WHERE MaPhatThe = @MaPhatThe";
            SqlCommand command = new SqlCommand(queryString);
            phatthe = new PHATTHE()
            {
                MaCauThu = "",
                MaLoaiThe = "",
                ThoiDiem = new TimeSpan(0),
            };
            try
            {
                command.Parameters.AddWithValue("@MaPhatThe", MaPhatThe);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    phatthe.MaCauThu = reader.GetString(1);
                    phatthe.MaLoaiThe = reader.GetString(2);
                    phatthe.ThoiDiem = reader.GetTimeSpan(3);
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
