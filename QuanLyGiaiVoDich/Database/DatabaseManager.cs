using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyGiaiVoDich.Database
{
    class DatabaseManager
    {
        //singleton class to get sql connection interface
        //to prevent opening and closing too much connection
        //use Database.DatabaseManger.Instance.getConnection() to get connection

        private static DatabaseManager instance = null;
        private string connectionString = ConfigurationManager.ConnectionStrings["QuanLyGiaiVoDich.Properties.Settings.QuanLyGiaiVoDichConnectionString"].ConnectionString;
        private SqlConnection connection = null;

        public DatabaseManager()
        {
            //initialize connection to database
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                //TODO: properly throw this to the UI layer to display error message or create simple dialog in this class
                Console.WriteLine(ex.Message);
            }
        }
        
        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        public void terminateConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
