using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Manager
{
    // This class handles all database connections
    // We use it everywhere so we don't repeat the connection string
    public class DBHelper
    {
        // Get the connection string from App.config
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString;

        // Call this to get an open connection
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}