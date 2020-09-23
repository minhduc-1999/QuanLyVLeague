using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyGiaiVoDich.Database
{
    class BangXepHang_DAO
    {
        public static void updateBXH(string MaMuaGiai)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "EXEC BXH @MaMuaGiai = @MaMuaThucHien";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaThucHien", MaMuaGiai);
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

        //base tiebreaker function to resolve tie between 2 team by reading head-to-head result
        private static int tieBreaker(string MaDoi1, string MaDoi2)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT * FROM TRANDAU WHERE (DoiChuNha = @MaDoi1 AND DoiKhach = @MaDoi2) OR (DoiChuNha = @MaDoi2 AND DoiKhach = @MaDoi1)";
            SqlCommand command = new SqlCommand(queryString);
            int[] tbRes = { 0, 0 };
            try
            {
                //command.Parameters.AddWithValue("@MaMuaThucHien", MaMuaGiai);
                command.Parameters.AddWithValue("@MaDoi1", MaDoi1);
                command.Parameters.AddWithValue("@MaDoi2", MaDoi2);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //identify which team is home team (and deduct the away team from that)
                    if (reader.GetString(2).Equals(MaDoi1))
                    {
                        if (reader.IsDBNull(10) || reader.IsDBNull(11)) continue;
                        if (reader.GetInt32(10) > reader.GetInt32(11)) tbRes[0]++;
                        else if (reader.GetInt32(10) < reader.GetInt32(11)) tbRes[1]++;
                    }
                    else if (reader.GetString(2).Equals(MaDoi2))
                    {
                        if (reader.IsDBNull(10) || reader.IsDBNull(11)) continue;
                        if (reader.GetInt32(10) > reader.GetInt32(11)) tbRes[1]++;
                        else if (reader.GetInt32(10) < reader.GetInt32(11)) tbRes[0]++;
                    }
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
            //Console.WriteLine(tbRes[0] + " " + tbRes[1]);
            if (tbRes[0] > tbRes[1]) return 1;
            else if (tbRes[0] < tbRes[1]) return -1;
            return 0;
        }

        public static List<helper.MutablePair<String, int>> tieBreaker(List<String> MaDoi)
        {
            List<helper.MutablePair<String, int>> res = new List<helper.MutablePair<String, int>>();
            foreach (String entry in MaDoi)
            {
                res.Add(new helper.MutablePair<String, int>(entry, 0));
            }
            for (int i = 0; i < res.Count; i++)
            {
                for (int j = i + 1; j < res.Count; j++)
                {
                    int pairRes = tieBreaker(res[i].First, res[j].First);
                    //change
                    if (pairRes == 1) res[i].Second++;
                    if (pairRes == -1) res[j].Second++;
                }
            }

            res.Sort((helper.MutablePair<String, int> a, helper.MutablePair<String, int> b) =>
            {
                return b.Second - a.Second;
            });
            //debug logger
            //for (int i = 0; i < res.Count; i++)
            //{
            //    Console.WriteLine(res[i].First + " - " + res[i].Second);
            //}
            //return a list of pair (teamId is first, priority is second. Higher pr = higher position, same pr = still tie)
            return res;
        }

        public static void updateXepHang(String MaDoi, DateTime Ngay, int XepHangMoi)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE BANGXEPHANG SET XepHang = @XepHang WHERE MaDoi = @MaDoi AND Ngay = @Ngay";
            SqlCommand command = new SqlCommand(queryString);
            int[] tbRes = { 0, 0 };
            try
            {
                //command.Parameters.AddWithValue("@MaMuaThucHien", MaMuaGiai);
                command.Parameters.AddWithValue("@MaDoi", MaDoi);
                command.Parameters.AddWithValue("@Ngay", Ngay.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@XepHang", XepHangMoi);
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

        public static List<String> getTop3(string MaMuaGiai)
        {
            List<string> result = new List<string>();
            DateTime targetTime = new DateTime(0);
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT XepHang, TenDoi, Ngay FROM (BANGXEPHANG INNER JOIN DOIBONG ON DOIBONG.MaDoi = BANGXEPHANG.MaDoi) WHERE MaMuaGiai = @MaMuaGiai ORDER BY Ngay DESC, XepHang ASC";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@MaMuaGiai", MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (result.Count == 0)
                    {
                        result.Add(reader.GetString(1));
                        targetTime = reader.GetDateTime(2);
                        continue;
                    }
                    else if (result.Count < 3)
                    {
                        if (targetTime.CompareTo(reader.GetDateTime(2)) == 0)
                        {
                            result.Add(reader.GetString(1));
                        }
                        else break;
                    }
                    else break;
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
