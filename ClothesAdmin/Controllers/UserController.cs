using ClothesAdmin.Models;
using MySql.Data.MySqlClient;
using System;

namespace ClothesAdmin.Controllers
{
    internal class UserController
    {
        public static User GetUserByNameAndPassword(string name, string password)
        {
            User user = null;
            MySqlConnection connection = DbController.GetConnection();
            string sql = "SELECT id, name, email, role FROM user WHERE name = @NAME AND password = @PASSWORD";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = name;
            mySqlCommand.Parameters.Add("@PASSWORD", MySqlDbType.VarChar).Value = password;
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32("id");
                string userName = reader.GetString("name");
                string userEmail = reader.GetString("email");
                string userRole = reader.GetString("role");
                user = new User(id, userName, null, userEmail, userRole);
            }
            connection.Close();
            return user;
        }

    }
}
