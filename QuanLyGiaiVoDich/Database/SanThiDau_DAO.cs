using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyGiaiVoDich.Database
{
    //call example:
    //dataAccess
    class SanThiDau_DAO
    {
        //param: 
        public static void createSanThiDau(string tenSanThiDau, string maGiaiDau, string donViQuanLi, string maDoiNha = "")
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO SanThiDau(MaSanThiDau, TenSanThiDau, MaMuaGiai, DonViSoHuu) VALUES(NEWID(), @TenSanThiDau, @MaGiaiDau, @DonViQuanLi)";
            if (maDoiNha != "")
                queryString = "INSERT INTO SanThiDau(MaSanThiDau, TenSanThiDau, MaMuaGiai, DonViSoHuu, MaDoiNha) VALUES(NEWID(), @TenSanThiDau, @MaGiaiDau, @DonViQuanLi, @MaDoiNha)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenSanThiDau", tenSanThiDau);
                command.Parameters.AddWithValue("@MaGiaiDau", maGiaiDau);
                command.Parameters.AddWithValue("@DonViQuanLi", donViQuanLi);
                if (maDoiNha != "")
                    command.Parameters.AddWithValue("@MaDoiNha", maDoiNha);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    //res indicate number of row affected, if number is 0, no row is added and we know something gone wrong, throw exception
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
                //TODO: throw exception to higher level
            }
        }

        public static void removeSanThiDau(string MaSanThiDau) 
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM SanThiDau WHERE MaSanThiDau = @MaSanThiDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot Delete");
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
        public static void updateSanThiDau(string MaSanThiDau, string tenSanThiDau, string donViQuanLi, string maDoiNha)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "";
            queryString = "UPDATE SanThiDau SET TenSanThiDau = @TenSanThiDau, DonViSoHuu = @DonViQuanLi, MaDoiNha = @MaDoiNha WHERE MaSanThiDau = @MaSanThiDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenSanThiDau", tenSanThiDau);
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Parameters.AddWithValue("@DonViQuanLi", donViQuanLi);
                command.Parameters.AddWithValue("@MaDoiNha", maDoiNha);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    //res indicate number of row affected, if number is 0, no row is added and we know something gone wrong, throw exception
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
                //TODO: throw exception to higher level
            }
        }

        public static void updateSanThiDau(string MaSanThiDau, string tenSanThiDau, string donViQuanLi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "";
            queryString = "UPDATE SanThiDau SET TenSanThiDau = @TenSanThiDau, DonViSoHuu = @DonViQuanLi WHERE MaSanThiDau = @MaSanThiDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenSanThiDau", tenSanThiDau);
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Parameters.AddWithValue("@DonViQuanLi", donViQuanLi);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    //res indicate number of row affected, if number is 0, no row is added and we know something gone wrong, throw exception
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
                //TODO: throw exception to higher level
            }
        }


        public static void selectSanThiDau(string MaSanThiDau, out string TenSanThiDau, out string DonViSoHuu, out string MaDoiNha)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            TenSanThiDau = "";
            DonViSoHuu = "";
            MaDoiNha = "";
            string queryString = "SELECT TenSanThiDau, DonViSoHuu, MaDoiNha FROM SANTHIDAU WHERE MaSanThiDau = @MaSanThiDau";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaSanThiDau", MaSanThiDau);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                {
                    TenSanThiDau = reader.GetString(0);
                    DonViSoHuu = reader.GetString(1);
                    if (!reader.IsDBNull(2)) MaDoiNha = reader.GetString(2);
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
        public static string queryMaSanNha(string MaDoi)
        {
            string result = "";
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaSanThiDau FROM SANTHIDAU WHERE MaDoiNha = @MaDoiNha";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaDoiNha", MaDoi);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0)) result = reader.GetString(0);
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
            return result;
        }

        public static string queryMaSanThiDau(string TenSan, string MuaGiai)
        {
            string result = "0";
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaSanThiDau FROM SANTHIDAU WHERE TenSanThiDau = @TenSanThiDau AND MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenSanThiDau", TenSan);
                command.Parameters.AddWithValue("@MaMuaGiai", MuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0)) result = reader.GetString(0);
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
            return result;
        }
    }
}
