using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ENCHERE.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private string connectionString = "Server=KHALIL;Database=enchere_db;User Id=sa;Password=khalillaafou;";

        [HttpGet("{userId}")]
        public IActionResult GetUser(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM User WHERE [Id] = @UserId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var user = new
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                // Add other user properties here
                            };
                            return Ok(user);
                        }
                        return NotFound();
                    }
                }
            }
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            List<object> users = new List<object>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [User]";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            // Add other user properties here
                        });
                    }
                }
            }

            return Ok(users);
        }

        // Add other CRUD methods (e.g., Create, Update, Delete) as needed.
    }
}
