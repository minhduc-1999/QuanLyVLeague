using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class BanThang_DAO
    {
        public static void createBanThang(BANTHANG banThang)
        {
            string ThoiDiem = banThang.ThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO BANTHANG Values (NEWID(),@MaCauThu,@MaLoaiBanThang,@ThoiDiem,@MaTranDau)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", banThang.MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiBanThang", banThang.MaLoaiBanThang);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", banThang.MaTranDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot insert New Goal!");
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
        public static void removeBanThang(string MaBanThang)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM BANTHANG WHERE MaBanThang = @MaBanThang";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaBanThang", MaBanThang);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot remove Goal!");
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
        public static void updateBanThang(BANTHANG banThang)
        {
            string ThoiDiem = banThang.ThoiDiem.ToString("c");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE BANTHANG SET MaCauThu = @MaCauThu, MaLoaiBanThang = @MaLoaiBanThang, ThoiDiem = @ThoiDiem, MaTranDau = @MaTranDau WHERE MaBanThang = @MaBanThang";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", banThang.MaCauThu);
                command.Parameters.AddWithValue("@MaLoaiBanThang", banThang.MaLoaiBanThang);
                command.Parameters.AddWithValue("@ThoiDiem", ThoiDiem);
                command.Parameters.AddWithValue("@MaTranDau", banThang.MaTranDau);
                command.Parameters.AddWithValue("@MaBanThang", banThang.MaBanThang);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot update Goal!");
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
        public static void selectBanThang(string MaBanThang, out BANTHANG banThang)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();

            string queryString = "SELECT MaCauThu, MaLoaiBanThang, ThoiDiem FROM BANTHANG WHERE MaBanThang = @MaBanThang";
            SqlCommand command = new SqlCommand(queryString);
            banThang = new BANTHANG()
            {
                MaBanThang = MaBanThang,
                MaCauThu = "",
                MaLoaiBanThang = "",
                ThoiDiem = new TimeSpan(0)
            };
            try
            {
                command.Parameters.AddWithValue("@MaBanThang", MaBanThang);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    banThang.MaCauThu = reader.GetString(0);
                    banThang.MaLoaiBanThang = reader.GetString(1);
                    banThang.ThoiDiem = reader.GetTimeSpan(2);
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
