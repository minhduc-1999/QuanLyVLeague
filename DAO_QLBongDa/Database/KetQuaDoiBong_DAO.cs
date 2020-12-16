using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO_QLBongDa.Database
{
    public class KetQuaDoiBong_DAO
    {
        public static void createKetQuaDoiBong(string MaDoi, int Thang, int Thua, int Hoa, int HieuSo, int Diem, int SoBanThangSanKhach)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO KETQUADOIBONG Values (@MaDoi,@Thang,@Thua,@Hoa,@HieuSo,@Diem,@SoBanThangSanKhach)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Parameters.AddWithValue("@Thang", Thang);
                command.Parameters.AddWithValue("@Thua", Thua);
                command.Parameters.AddWithValue("@Hoa", Hoa);
                command.Parameters.AddWithValue("@HieuSo", HieuSo);
                command.Parameters.AddWithValue("@Diem", Diem);
                command.Parameters.AddWithValue("@SoBanThangSanKhach", SoBanThangSanKhach);
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
        public static void removeKetQuaDoiBong(string MaDoi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM KETQUADOIBONG WHERE MaDoi = @MaDoi";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
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

        public static void selectKetQuaDoiBong(string MaDoi, out int Thang, out int Thua, out int Hoa, out int HieuSo, out int Diem, out int SoBanThangSanKhach)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT Thang, Thua, Hoa, HieuSo, Diem, SoBanThangSanKhach FROM KETQUADOIBONG WHERE MaDoi = @MaDoi";
            SqlCommand command = new SqlCommand(queryString);
            Thang = 0;
            Thua = 0;
            Hoa = 0;
            HieuSo = 0;
            Diem = 0;
            SoBanThangSanKhach = 0;
            try
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Thang = reader.GetInt32(0);
                    Thua = reader.GetInt32(1);
                    Hoa = reader.GetInt32(2);
                    HieuSo = reader.GetInt32(3);
                    Diem = reader.GetInt32(4);
                    SoBanThangSanKhach = reader.GetInt32(5);
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
