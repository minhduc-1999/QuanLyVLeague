using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class DieuKien_DAO
    {
        public static void createDIEUKIEN(DIEUKIEN dk)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO DIEUKIEN Values (@MaMuaGiai, @TuoiToiThieu, @TuoiToiDa, @SoCauThuToiThieu, @SoCauThuToiDa, @SoCauThuNuocNgoaiToiDa, @SoLanThayNguoiToiDa, @DiemSoThang, @DiemSoThua, @DiemSoHoa)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", dk.MaMuaGiai);
                command.Parameters.AddWithValue("@TuoiToiThieu", dk.TuoiToiThieu);
                command.Parameters.AddWithValue("@TuoiToiDa", dk.TuoiToiDa);
                command.Parameters.AddWithValue("@SoCauThuToiThieu", dk.SoCauThuToiThieu);
                command.Parameters.AddWithValue("@SoCauThuToiDa", dk.SoCauThuToiDa);
                command.Parameters.AddWithValue("@SoCauThuNuocNgoaiToiDa", dk.SoCauThuNuocNgoaiToiDa);
                command.Parameters.AddWithValue("@SoLanThayNguoiToiDa", dk.SoLanThayNguoiToiDa);
                command.Parameters.AddWithValue("@DiemSoThang", dk.DiemSoThang);
                command.Parameters.AddWithValue("@DiemSoThua", dk.DiemSoThua);
                command.Parameters.AddWithValue("@DiemSoHoa", dk.DiemSoHoa);
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
        public static void removeDieuKien(string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM DIEUKIEN WHERE MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
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
        public static void updateDieuKien(DIEUKIEN dk)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE DIEUKIEN SET TuoiToiThieu = @TuoiToiThieu, TuoiToiDa = @TuoiToiDa, SoCauThuToiThieu = @SoCauThuToiThieu, SoCauThuToiDa = @SoCauThuToiDa, SoCauThuNuocNgoaiToiDa = @SoCauThuNuocNgoaiToiDa, SoLanThayNguoiToiDa = @SoLanThayNguoiToiDa, DiemSoThang = @DiemSoThang, DiemSoThua = @DiemSoThua, DiemSoHoa = @DiemSoHoa WHERE MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", dk.MaMuaGiai);
                command.Parameters.AddWithValue("@TuoiToiThieu", dk.TuoiToiThieu);
                command.Parameters.AddWithValue("@TuoiToiDa", dk.TuoiToiDa);
                command.Parameters.AddWithValue("@SoCauThuToiThieu", dk.SoCauThuToiThieu);
                command.Parameters.AddWithValue("@SoCauThuToiDa", dk.SoCauThuToiDa);
                command.Parameters.AddWithValue("@SoCauThuNuocNgoaiToiDa", dk.SoCauThuNuocNgoaiToiDa);
                command.Parameters.AddWithValue("@SoLanThayNguoiToiDa", dk.SoLanThayNguoiToiDa);
                command.Parameters.AddWithValue("@DiemSoThang", dk.DiemSoThang);
                command.Parameters.AddWithValue("@DiemSoThua", dk.DiemSoThua);
                command.Parameters.AddWithValue("@DiemSoHoa", dk.DiemSoHoa);
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

        public static void selectDieuKien(string MaMuaGiai, out DIEUKIEN dk)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM DIEUKIEN WHERE MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            dk = new DIEUKIEN() { MaMuaGiai = MaMuaGiai};           
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dk.TuoiToiThieu = reader.GetInt32(1);
                    dk.TuoiToiDa = reader.GetInt32(2);
                    dk.SoCauThuToiThieu = reader.GetInt32(3);
                    dk.SoCauThuToiDa = reader.GetInt32(4);
                    dk.SoCauThuNuocNgoaiToiDa = reader.GetInt32(5);
                    dk.SoLanThayNguoiToiDa = reader.GetInt32(6);
                    dk.DiemSoThang = reader.GetInt32(7);
                    dk.DiemSoThua = reader.GetInt32(8);
                    dk.DiemSoHoa = reader.GetInt32(9);
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

        public static void queryGioiHanTuoi(string MaMuaGiai, out int tuoiToiThieu, out int tuoiToiDa)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM DIEUKIEN WHERE MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);

            tuoiToiThieu = 0;
            tuoiToiDa = 0;
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tuoiToiThieu = reader.GetInt32(1);
                    tuoiToiDa = reader.GetInt32(2);
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
