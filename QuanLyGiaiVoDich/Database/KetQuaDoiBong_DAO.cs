using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class KetQuaDoiBong_DAO
    {
        public static void createKetQuaDoiBong(KETQUADOIBONG kq)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO KETQUADOIBONG Values (@MaDoi,@Thang,@Thua,@Hoa,@HieuSo,@Diem,@SoBanThangSanKhach)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaDoi", kq.MaDoi);
                command.Parameters.AddWithValue("@Thang", kq.Thang);
                command.Parameters.AddWithValue("@Thua", kq.Thua);
                command.Parameters.AddWithValue("@Hoa", kq.Hoa);
                command.Parameters.AddWithValue("@HieuSo", kq.HieuSo);
                command.Parameters.AddWithValue("@Diem", kq.Diem);
                command.Parameters.AddWithValue("@SoBanThangSanKhach", kq.SoBanThangSanKhach);
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

        public static void selectKetQuaDoiBong(string MaDoi, out KETQUADOIBONG kq)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT Thang, Thua, Hoa, HieuSo, Diem, SoBanThangSanKhach FROM KETQUADOIBONG WHERE MaDoi = @MaDoi";
            SqlCommand command = new SqlCommand(queryString);
            kq = new KETQUADOIBONG(MaDoi);
            try
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kq.Thang = reader.GetInt32(0);
                    kq.Thua = reader.GetInt32(1);
                    kq.Hoa = reader.GetInt32(2);
                    kq.HieuSo = reader.GetInt32(3);
                    kq.Diem = reader.GetInt32(4);
                    kq.SoBanThangSanKhach = reader.GetInt32(5);
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
