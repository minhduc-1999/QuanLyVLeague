using System;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class DanhSachThamGia_DAO
    {
        public static void createDanhSachThamGia(DANHSACHTHAMGIA dsThamGia)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO DANHSACHTHAMGIA Values (@MaTranDau,@MaCauThu,@CauThuDuBi,@CauThuChinhThuc)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", dsThamGia.MaTranDau);
                command.Parameters.AddWithValue("@MaCauThu", dsThamGia.MaCauThu);
                command.Parameters.AddWithValue("@CauThuDuBi", dsThamGia.CauThuDuBi);
                command.Parameters.AddWithValue("@CauThuChinhThuc", dsThamGia.CauThuChinhThuc);
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
        public static void updateDanhSachThamGia(DANHSACHTHAMGIA dsthamGia)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE DANHSACHTHAMGIA SET CauThuDuBi = @CauThuDuBi, CauThuChinhThuc = @CauThuChinhThuc WHERE MaTranDau = @MaTranDau AND MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", dsthamGia.MaTranDau);
                command.Parameters.AddWithValue("@MaCauThu", dsthamGia.MaCauThu);
                command.Parameters.AddWithValue("@CauThuDuBi", dsthamGia.CauThuDuBi);
                command.Parameters.AddWithValue("@CauThuChinhThuc", dsthamGia.CauThuChinhThuc);
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
        public static void selectDanhSachThamGia(string MaTranDau, string MaCauThu, out DANHSACHTHAMGIA dsThamGia)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT CauThuDuBi, CauThuChinhThuc FROM DANHSACHTHAMGIA WHERE MaTranDau = @MaTranDau AND MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            dsThamGia = new DANHSACHTHAMGIA()
            {
                MaTranDau = MaTranDau,
                MaCauThu = MaCauThu,
                CauThuDuBi = false,
                CauThuChinhThuc = false
            };       
            try
            {
                command.Parameters.AddWithValue("@MaTranDau", MaTranDau);
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dsThamGia.CauThuDuBi = reader.GetBoolean(0);
                    dsThamGia.CauThuChinhThuc = reader.GetBoolean(1);
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
