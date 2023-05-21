using ClothesAdmin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClothesAdmin.Controllers
{
    internal class ClientController
    {

        public static int AddClient(Client client, Boolean showAlert = false)
        {
            string sql = "INSERT INTO client (dni, email) VALUES(@DNI, @EMAIL); SELECT LAST_INSERT_ID()";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@DNI", MySqlDbType.VarChar).Value = client.DNI;
            mySqlCommand.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = client.Email;
            try
            {
                int clientId = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                if (showAlert) {
                    MessageBox.Show("Added Successfully! Client ID: " + clientId.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return clientId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client not inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }

        public static List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();

            string sql = "SELECT id, dni, email FROM client";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string dni = reader.GetString("dni");
                string email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email");

                Client client = new Client(
                    id,
                    dni,
                    email
                );

                clients.Add(client);
            }

            connection.Close();

            return clients;
        }

        public static Client GetClientByEmail(string email)
        {
            Client client = null;
            string sql = "SELECT id, dni, email FROM client WHERE email = @EMAIL";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = email;
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32("id");
                string dni = reader.GetString("dni");
                string emailFromDB = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email");
                client = new Client(
                    id,
                    dni,
                    emailFromDB
                );
            }
            connection.Close();
            return client;
        }

        public static Client GetClientByDNI(string dni)
        {
            Client client = null;
            string sql = "SELECT id, dni, email FROM client WHERE dni = @DNI";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@DNI", MySqlDbType.VarChar).Value = dni;
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32("id");
                string dniFromDB = reader.GetString("dni");
                string email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email");
                client = new Client(
                    id,
                    dniFromDB,
                    email
                );
            }
            connection.Close();
            return client;
        }

    }
}
