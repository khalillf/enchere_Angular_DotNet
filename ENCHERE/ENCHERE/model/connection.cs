using System;
using System.Data;
using System.Data.SqlClient;

namespace YourNamespace
{
    public class DatabaseAccess
    {
        private string connectionString = "Server=KHALIL;Database=enchere_db;User Id=KHALIL;Password=;";

        public void ConnectAndQueryDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM user";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            
                        }
                    }
                }
            }
        }
    }
}
