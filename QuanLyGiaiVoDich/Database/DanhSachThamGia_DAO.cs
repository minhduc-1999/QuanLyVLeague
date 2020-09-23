using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyGiaiVoDich.Database
{
    class DanhSachThamGia_DAO
    {
        public static void createDanhSachThamGia(string MaTranDau, string MaCauThu, bool CauThuDuBi, bool CauThuChinhThuc)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO DANHSACHTHAMGIA Values (@MaTranDau,@MaCauThu,@CauThuDuBi,@CauThuChinhThuc)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@CauThuDuBi", CauThuDuBi);
                command.Parameters.AddWithValue("@CauThuChinhThuc", CauThuChinhThuc);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Không thể thêm thông tin tham gia");
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
        public static void removeDanhSachThamGia(string MaTranDau, string MaCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM DANHSACHTHAMGIA WHERE MaTranDau = @MaTranDau AND MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Không thể xóa cầu thủ khỏi danh sách");
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
        public static void updateDanhSachThamGia(string MaTranDau, string MaCauThu, bool CauThuDuBi, bool CauThuChinhThuc)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE DANHSACHTHAMGIA SET CauThuDuBi = @CauThuDuBi, CauThuChinhThuc = @CauThuChinhThuc WHERE MaTranDau = @MaTranDau AND MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@CauThuDuBi", CauThuDuBi);
                command.Parameters.AddWithValue("@CauThuChinhThuc", CauThuChinhThuc);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Không thể cập nhật thông tin tham gia");
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
        public static void selectDanhSachThamGia(string MaTranDau, string MaCauThu, out bool CauThuDuBi, out bool CauThuChinhThuc)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT CauThuDuBi, CauThuChinhThuc FROM DANHSACHTHAMGIA WHERE MaTranDau = @MaTranDau AND MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            CauThuChinhThuc = false;
            CauThuDuBi = false;            
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CauThuDuBi = reader.GetBoolean(0);
                    CauThuChinhThuc = reader.GetBoolean(1);
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
