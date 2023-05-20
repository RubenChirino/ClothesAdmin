using ClothesAdmin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using ClothesAdmin.Controllers;
using System.Data;

namespace ClothesAdmin.Classes
{
    internal class ProductController
    {

        public static void AddProduct(Product product)
        {
            string sql = "INSERT INTO product (name, image, description, stock, price, color, size, categorie, active) VALUES(@NAME, @IMAGE, @DESCRIPTION, @STOCK, @PRICE, @COLOR, @SIZE, @CATEGORIE, @ISACTIVE)";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = product.Name;
            mySqlCommand.Parameters.Add("@IMAGE", MySqlDbType.VarChar).Value = product.Image;
            mySqlCommand.Parameters.Add("@DESCRIPTION", MySqlDbType.VarChar).Value = product.Description;
            mySqlCommand.Parameters.Add("@STOCK", MySqlDbType.Int64).Value = product.Stock;
            mySqlCommand.Parameters.Add("@PRICE", MySqlDbType.Decimal).Value = product.Price;
            mySqlCommand.Parameters.Add("@COLOR", MySqlDbType.VarChar).Value = product.Color;
            mySqlCommand.Parameters.Add("@SIZE", MySqlDbType.VarChar).Value = product.Size.ToString();
            mySqlCommand.Parameters.Add("@CATEGORIE", MySqlDbType.VarChar).Value = product.Categorie;
            mySqlCommand.Parameters.Add("@ISACTIVE", MySqlDbType.Int16).Value = product.IsActive;
            try 
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateProduct(string id, Product product)
        {
            string sql = "UPDATE product SET name = @Name, image = @IMAGE, description = @DESCRIPTION, stock = @STOCK, price = @PRICE, color = @COLOR, size = @SIZE, categorie = @CATEGORIE, active = @ISACTIVE WHERE id = @ID";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            mySqlCommand.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = product.Name;
            mySqlCommand.Parameters.Add("@IMAGE", MySqlDbType.VarChar).Value = product.Image;
            mySqlCommand.Parameters.Add("@DESCRIPTION", MySqlDbType.VarChar).Value = product.Description;
            mySqlCommand.Parameters.Add("@STOCK", MySqlDbType.Int64).Value = product.Stock;
            mySqlCommand.Parameters.Add("@PRICE", MySqlDbType.Decimal).Value = product.Price;
            mySqlCommand.Parameters.Add("@COLOR", MySqlDbType.VarChar).Value = product.Color;
            mySqlCommand.Parameters.Add("@SIZE", MySqlDbType.VarChar).Value = product.Size.ToString();
            mySqlCommand.Parameters.Add("@CATEGORIE", MySqlDbType.VarChar).Value = product.Categorie;
            mySqlCommand.Parameters.Add("@ISACTIVE", MySqlDbType.VarChar).Value = product.IsActive.ToString();
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteProduct(string id)
        {
            string sql = "DELETE FROM product WHERE id = @ID";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void displayProduct(string query, DataGridView dgv)
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
