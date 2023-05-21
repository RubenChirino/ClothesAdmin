using ClothesAdmin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClothesAdmin.Controllers
{
    internal class SaleController
    {
        public static void AddSale(Sale sale, double total)
        {
            string sql = "INSERT INTO sale (total, id_user, id_product, id_client) VALUES(@TOTAL, @ID_USER, @ID_PRODUCT, @ID_CLIENT)";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@TOTAL", MySqlDbType.Double).Value = total;
            mySqlCommand.Parameters.Add("@ID_PRODUCT", MySqlDbType.VarChar).Value = sale.IdProduct;
            mySqlCommand.Parameters.Add("@ID_USER", MySqlDbType.VarChar).Value = sale.IdUser;
            mySqlCommand.Parameters.Add("@ID_CLIENT", MySqlDbType.VarChar).Value = sale.IdClient;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sale not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DisplaySale(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            connection.Close();
        }
    }
}
