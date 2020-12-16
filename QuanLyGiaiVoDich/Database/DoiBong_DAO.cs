using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;

namespace QuanLyGiaiVoDich.Database
{
    class DoiBong_DAO
    {
        public static void createDoiBong(DOIBONG doiBong)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO DOIBONG Values (NEWID(),@MaMuaGiai,@TenDoiBong)";
            SqlCommand command = new SqlCommand(queryString);
            try 
            {
                command.Parameters.AddWithValue("@MaMuaGiai", doiBong.MaMuaGiai);
                command.Parameters.AddWithValue("@TenDoiBong", doiBong.TenDoi);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0) 
                {
                    throw new Exception("Cannot insert Soccer Team!");
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

        public static void removeDoiBong(string MaDoi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM DOIBONG WHERE MaDoi = @MaDoi";
            SqlCommand command = new SqlCommand(queryString);
            try 
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot remove Soccer Team!");
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

        public static void updateDoiBong(DOIBONG doibong)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE DOIBONG SET TenDoi = @TenDoiBongMoi WHERE MaDoi = @MaDoi";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@TenDoiBongMoi", doibong.TenDoi);
                command.Parameters.AddWithValue("@MaDoi", doibong.MaDoi);
                command.Connection = conn;
                int res = command.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Cannot update Soccer Team!");
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
        public static void selectDoiBong(string MaDoi, out DOIBONG doibong)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaMuaGiai, TenDoi FROM DOIBONG WHERE MaDoi = @MaDoi";
            SqlCommand command = new SqlCommand(queryString);
            doibong = new DOIBONG() { MaDoi = MaDoi };
            try
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Connection = conn;
                SqlDataReader sqlreader = command.ExecuteReader();
                if (sqlreader.Read())
                {
                    doibong.MaMuaGiai = sqlreader.GetString(0);
                    doibong.TenDoi = sqlreader.GetString(1);
                }
                sqlreader.Close();
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

        public static string queryMaDoiBong(string TenDoi, string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT MaDoi FROM DOIBONG WHERE TenDoi = @TenDoi AND MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            String MaDoi = "";
            try
            {
                command.Parameters.AddWithValue("@TenDoi", TenDoi);
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader sqlreader = command.ExecuteReader();
                if (sqlreader.Read())
                {
                    if (!sqlreader.IsDBNull(0)) MaDoi = sqlreader.GetString(0);
                }
                sqlreader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return MaDoi;
        }

        public static string queryTenDoiBong(string MaDoi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenDoi FROM DOIBONG WHERE MaDoi = @MaDoi";
            SqlCommand command = new SqlCommand(queryString);
            String TenDoi = "";
            try
            {
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Connection = conn;
                SqlDataReader sqlreader = command.ExecuteReader();
                if (sqlreader.Read())
                {
                    TenDoi = sqlreader.GetString(0);
                }
                sqlreader.Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return TenDoi;
        }

        public static string checkSoCauThuToiThieu(string MaDoi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "EXEC SoCauThuToiThieu @MaDoi = @MaMoi";
            SqlCommand command = new SqlCommand(queryString);
            string printResult = "";
            SqlInfoMessageEventHandler handler = (object obj, SqlInfoMessageEventArgs e) => {
                printResult += e.Message;
            };
            conn.InfoMessage += handler;
            try
            {
                command.Parameters.AddWithValue("@MaMoi", MaDoi);
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conn.InfoMessage -= handler;
            return printResult;
        } 
    }
}
