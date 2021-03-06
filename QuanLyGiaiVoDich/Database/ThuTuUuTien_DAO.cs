﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyGiaiVoDich.DTO_Class.Class;


namespace QuanLyGiaiVoDich.Database
{
    class ThuTuUuTien_DAO
    {
        public static void createThuTuUuTien(THUTUUUTIEN thutuuutien)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "INSERT INTO THUTUUUTIEN Values (@ChiSoUuTien, @MaMuaGiai, @TenLoaiUuTien)";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@ChiSoUuTien", thutuuutien.ChiSoUuTien);
                command.Parameters.AddWithValue("@MaMuaGiai", thutuuutien.MaMuaGiai);
                command.Parameters.AddWithValue("@TenLoaiUuTien", thutuuutien.TenLoaiUuTien);
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
        public static void removeThuTuUuTien(int ChiSoUuTien)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "DELETE FROM THUTUUUTIEN WHERE ChiSoUuTien = @ChiSoUuTien";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@ChiSoUuTien", ChiSoUuTien);
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
        //public static void updateThuTuUuTien(int ChiSoUuTien, string MaMuaGiai, string TenLoaiUuTien)
        public static void updateThuTuUuTien(THUTUUUTIEN thutu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "UPDATE THUTUUUTIEN SET TenLoaiUuTien = @TenLoaiUuTien WHERE ChiSoUuTien = @ChiSoUuTien AND MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            try
            {
                command.Parameters.AddWithValue("@ChiSoUuTien", thutu.ChiSoUuTien);
                command.Parameters.AddWithValue("@MaMuaGiai", thutu.MaMuaGiai);
                command.Parameters.AddWithValue("@TenLoaiUuTien", thutu.TenLoaiUuTien);
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
        //public static string selectThuTuUuTien(int ChiSoUuTien, string MaMuaGiai)
        public static string selectThuTuUuTien(THUTUUUTIEN thutu)
        {
            SqlConnection conn = DatabaseManager.Instance.getConnection();
            string queryString = "SELECT TenLoaiUuTien FROM THUTUUUTIEN WHERE ChiSoUuTien = @ChiSoUuTien AND MaMuaGiai = @MaMuaGiai";
            SqlCommand command = new SqlCommand(queryString);
            string TenLoaiUuTien = "";
            try
            {
                command.Parameters.AddWithValue("@ChiSoUuTien",thutu.ChiSoUuTien);
                command.Parameters.AddWithValue("@MaMuaGiai", thutu.MaMuaGiai);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TenLoaiUuTien = reader.GetString(0);
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
            return TenLoaiUuTien;
        }
    }
}
