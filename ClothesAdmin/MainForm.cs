using ClothesAdmin.Classes;
using ClothesAdmin.Controllers;
using ClothesAdmin.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ClothesAdmin.ProductForm;

namespace ClothesAdmin
{
    public partial class MainForm : Form
    {
        public User user;
        public int selectedProductId;
        public int selectedSaleId;

        public MainForm(User user, string screenToShow = "")
        {
            this.user = user;
            InitializeComponent(user);
            userNameLabel.Text = user.Name;

            // Events
            productsDataGrid.CellClick += productsDataGrid_CellClick;
            salesDataGrid.CellClick += salesDataGrid_CellClick;

            // Get Data
            ProductController.DisplayProduct("SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product", productsDataGrid);
            SaleController.DisplaySale("SELECT id, total, id_user, id_product, id_client FROM sale", salesDataGrid);

            // Elements
            if (user.Role != "admin")
            {
                productsBtn.Visible = false;
                productsBtnBorder.Visible = false;
            }
            productEditBtn.Visible = false;
            productActivateBtn.Visible = false;
            productDeleteBtn.Visible = false;
            /* salesEditBtn.Visible = false;
            salesDeleteBtn.Visible = false; */

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
           new ProductForm(user, -1).Show();
           this.Hide();
        }

        private void brandTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void salesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell idCell = productsDataGrid.Rows[e.RowIndex].Cells["ID"];
                if (idCell.Value != null)
                {
                    selectedSaleId = Convert.ToInt32(idCell.Value);
                    // Show EDIT & DELETE Buttons
                    /* salesEditBtn.Visible = true;
                    salesDeleteBtn.Visible = true; */
                }
            }
        }

        private void productsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell idCell = productsDataGrid.Rows[e.RowIndex].Cells["ID"];
                DataGridViewCell isActiveCell = productsDataGrid.Rows[e.RowIndex].Cells["ACTIVE"];

                if (idCell.Value != null)
                {
                    selectedProductId = Convert.ToInt32(idCell.Value);
                    int IsProductActive = Convert.ToInt32(isActiveCell.Value);

                    // Show EDIT & DELETE Buttons

                    if (IsProductActive == 1) 
                    {
                        productActivateBtn.Visible = false;
                        productDeleteBtn.Visible = true;
                    } else
                    {
                        productDeleteBtn.Visible = false;
                        productActivateBtn.Visible = true;
                    }

                    productEditBtn.Visible = true;
                   
                }
            }
        }

        private void productsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ProductController.DisplayProduct("SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product WHERE name LIKE'%" + textBoxSearchProduct.Text + "%'", productsDataGrid);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SaleController.DisplaySale("SELECT id, total, id_user, id_product, id_client FROM sale WHERE id LIKE'%" + textBoxSeachSales.Text + "%'", salesDataGrid);
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
            new SaleForm(user, -1).Show();
            this.Hide();
        }

        private void salesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPanelSales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridPanelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productEditBtn_Click(object sender, EventArgs e)
        {
            new ProductForm(user, selectedProductId).Show();
            this.Hide();
        }

        private void productDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Are you sure to desactivate the product?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProductController.ActivateOrDesactivateProduct(selectedProductId, 0);
                ProductController.DisplayProduct("SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product", productsDataGrid);
            }
        }

        private void productActivateBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Are you sure to activate the product?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProductController.ActivateOrDesactivateProduct(selectedProductId, 1);
                ProductController.DisplayProduct("SELECT id, name, image, description, stock, price, color, size, categorie, active FROM product", productsDataGrid);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new AuthenticationForm().Show();
            this.Hide();
            user = null;
        }
    }
}
