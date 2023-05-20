using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ClothesAdmin.Controllers
{
    internal class DbController
    {

        public static MySqlConnection GetConnection()
        { 
            string sql = "datasource=localhost;port=3306;username=root;password=;database=clothes_store";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

    }
}
