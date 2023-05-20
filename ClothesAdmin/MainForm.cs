using ClothesAdmin.Classes;
using ClothesAdmin.Models;
using System;
using System.Windows.Forms;
using static ClothesAdmin.ProductForm;

namespace ClothesAdmin
{
    public partial class MainForm : Form
    {
        public User user;

        public MainForm(User user, string screenToShow = "")
        {
            this.user = user;
            InitializeComponent(user);
            userNameLabel.Text = user.Name;

            ProductController.displayProduct("SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product", productsDataGrid);

            if (user.Role != "admin")
            {
                productsBtn.Visible = false;
                productsBtnBorder.Visible = false;
            }

            // Default Screen & Navegation
            if (screenToShow.Length > 0) { 
                if (screenToShow == "products")
                {
                    ShowProductScreen();
                } else
                {
                    ShowSalesScreen();
                }
            } else
            {
                ShowSalesScreen();
            }
        }

        public void ShowProductScreen()
        {
            productsPanel.Visible = true;
            productsBtnBorder.Visible = true;

            salesPanel.Visible = false;
            salesBtnBorder.Visible = false;
        }

        public void ShowSalesScreen()
        {
            productsPanel.Visible = false;
            productsBtnBorder.Visible = false;

            salesPanel.Visible = true;
            salesBtnBorder.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowProductScreen();
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // New Product
        private void btnNew_Click(object sender, EventArgs e)
        {
           new ProductForm(user, 0).Show();
           this.Hide();
        }

        private void brandTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void productsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ProductController.displayProduct("SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product WHERE name LIKE'%" + textBoxSearchProduct.Text + "%'", productsDataGrid);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            ShowSalesScreen();
        }

        private void productsBtnBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salesBtnBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        // New Sale
        private void newSaleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
