using ClothesAdmin.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using ClothesAdmin.Controllers;
using System.Data;
using System.Collections.Generic;

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

        public static void UpdateProduct(int id, Product product, Boolean showAlert = false)
        {
            string sql = "UPDATE product SET name = @Name, image = @IMAGE, description = @DESCRIPTION, stock = @STOCK, price = @PRICE, color = @COLOR, size = @SIZE, categorie = @CATEGORIE, active = @ISACTIVE WHERE id = @ID";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
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
                if (showAlert) 
                {
                    MessageBox.Show("Updated Succesfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        // Physical Delete
        public static void DeleteProduct(int id)
        {
            string sql = "DELETE FROM product WHERE id = @ID"; 
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Desactivated Succesfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        // Logic Delete
        public static void ActivateOrDesactivateProduct(int id, int active)
        {
            // string sql = "DELETE FROM product WHERE id = @ID"; // Physical Delete
            string sql = "UPDATE product SET active = @ISACTIVE WHERE id = @ID";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            mySqlCommand.Parameters.Add("@ISACTIVE", MySqlDbType.Int32).Value = active;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                string msg = (active == 1) ? "Activated" : "Desactivated";
                MessageBox.Show(msg + " Succesfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DisplayProduct(string query, DataGridView dgv)
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

        public static Product GetProductById(int id)
        {
            Product product = null;
            string sql = "SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product WHERE id = @ID";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                product = new Product(
                    reader.GetInt32("id"),
                    reader.GetString("name"),
                    reader.GetString("image"),
                    reader.GetString("description"),
                    reader.GetInt32("stock"),
                    reader.GetDouble("price"),
                    reader.GetString("color"),
                    reader.GetString("size"),
                    reader.GetString("categorie"),
                    reader.GetInt16("active")
                );
            }
            connection.Close();
            return product;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            string sql = "SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product";
            MySqlConnection connection = DbController.GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product(
                    reader.GetInt32("id"),
                    reader.GetString("name"),
                    reader.GetString("image"),
                    reader.GetString("description"),
                    reader.GetInt32("stock"),
                    reader.GetDouble("price"),
                    reader.GetString("color"),
                    reader.GetString("size"),
                    reader.GetString("categorie"),
                    reader.GetInt16("active")
                );

                products.Add(product);
            }

            connection.Close();

            return products;
        }
    }
}
