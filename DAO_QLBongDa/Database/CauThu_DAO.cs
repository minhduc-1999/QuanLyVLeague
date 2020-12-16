using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyGiaiVoDich.Database
{
    public class CauThu_DAO
    {
        public static void createCauThu(string TenCauThu, DateTime dtNgaySinh, string MaLoaiCauThu, string GhiChu, string MaDoi, int SoBanThang, int SoAo)
        {
            string NgaySinh = dtNgaySinh.ToString("yyyy-MM-dd");
            //Console.WriteLine(NgaySinh);
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO CAUTHU Values (NEWID(), @TenCauThu, @NgaySinh, NULL, @MaLoaiCauThu, @GhiChu, @MaDoi, @SoBanThang, @SoAo)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenCauThu",TenCauThu);
                command.Parameters.AddWithValue("@NgaySinh",NgaySinh);
                command.Parameters.AddWithValue("@MaLoaiCauThu", MaLoaiCauThu);
                command.Parameters.AddWithValue("@GhiChu", GhiChu);
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Parameters.AddWithValue("@SoBanThang", SoBanThang);
                command.Parameters.AddWithValue("@SoAo", SoAo);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot insert Soccer Player!");
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
        public static void removeCauThu(string MaCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM CAUTHU WHERE MaCauThu = @MaCauThu ";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot remove Soccer Player!");
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
        public static void updateCauThu(string MaCauThu, string TenCauThu, DateTime dtNgaySinh, string MaLoaiCauThu, string GhiChu, string MaDoi, int SoBanThang, int SoAo)
        {
            string NgaySinh = dtNgaySinh.ToString("YYYY-MM-DD");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE CAUTHU SET TenCauThu = @TenCauThu, NgaySinh = @NgaySinh, MaLoaiCauThu = @MaLoaiCauThu, GhiChu = @GhiChu, MaDoi = @MaDoi, SoBanThang = @SoBanThang, SoAo = @SoAo WHERE MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@TenCauThu", TenCauThu);
                command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                command.Parameters.AddWithValue("@MaLoaiCauThu", MaLoaiCauThu);
                command.Parameters.AddWithValue("@GhiChu", GhiChu);
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Parameters.AddWithValue("@SoBanThang", SoBanThang);
                command.Parameters.AddWithValue("@SoAo", SoAo);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot update Soccer Player!");
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

        //Ghi nhận kết quả trận đấu => cầu thủ vừa ghi được bàn thắng => update SoBanThang

        public static void GetNewScore(string MaCauThu) 
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE CAUTHU SET SoBanThang = SoBanThang + 1 WHERE MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
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

        public static void removeScore(string MaCauThu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE CAUTHU SET SoBanThang = SoBanThang - 1 WHERE MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
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

        public static void selectCauThu(string MaCauThu, out string TenCauThu, out DateTime NgaySinh, out string MaLoaiCauThu, out string GhiChu, out string MaDoi, out int SoBanThang, out int SoAo)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenCauThu, NgaySinh, MaLoaiCauThu, GhiChu, MaDoi, SoBanThang, SoAo FROM CAUTHU WHERE MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            TenCauThu = "";
            NgaySinh = new DateTime(0);
            MaLoaiCauThu = "";
            GhiChu = "";
            MaDoi = "";
            SoBanThang = 0;
            SoAo = 1;
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    TenCauThu = reader.GetString(0);
                    NgaySinh = reader.GetDateTime(1);
                    MaLoaiCauThu = reader.GetString(2);
                    GhiChu = reader.GetString(3);
                    MaDoi = reader.GetString(4);
                    SoBanThang = reader.GetInt32(5);
                    SoAo = reader.GetByte(6);
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

        public static void updateRoiDoiBong(string MaCauThu, DateTime dtNgayRoi)
        {
            string NgayRoi = dtNgayRoi.ToString("yyyy-MM-dd");
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE CAUTHU SET NgayRoiDi = @NgayRoiDi WHERE MaCauThu = @MaCauThu";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaCauThu", MaCauThu);
                command.Parameters.AddWithValue("@NgayRoiDi", NgayRoi);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot update Soccer Player!");
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

        public static List<string> getTop3(string MaMuaGiai)
        {
            List<string> result = new List<string>();
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT CAUTHU.TenCauThu, CAUTHU.SoBanThang, DOIBONG.MaMuaGiai, CAUTHU.SoAo FROM CAUTHU INNER JOIN DOIBONG ON CAUTHU.MaDoi = DOIBONG.MaDoi WHERE MaMuaGiai = @MaMuaGiai AND CAUTHU.SoBanThang > 0 ORDER BY CAUTHU.SoBanThang DESC";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                    if (result.Count >= 3) break;
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
            while (result.Count < 3)
            {
                result.Add("-");
            }
            return result;
        }
    }
}
