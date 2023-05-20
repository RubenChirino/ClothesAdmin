using ClothesAdmin.Classes;
using ClothesAdmin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesAdmin
{
    public partial class ProductForm : Form
    {
        public User user;
        private int ProductId;
        public enum Actions
        {
            add,
            update
        }

        public ProductForm(User user, int productId)
        {
            this.user = user;
            this.ProductId = productId;

            InitializeComponent();

            if (productId != null)
            {
                // Set Product Info

            }
            else 
            {
                // Set default Info
                Array sizeOptions = Enum.GetValues(typeof(Product.Sizes));
                comboBoxSize.DataSource = sizeOptions;

                Array categorieOptions = Enum.GetValues(typeof(Product.Categories));
                comboBoxCategorie.DataSource = categorieOptions;
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        // Save Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Validations

            // Name
            if (textBoxName.Text == null || textBoxName.Text.Length > 0)
            {
                MessageBox.Show("You need to add a name to the product! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Description
            if (textBoxDescription.Text == null || textBoxDescription.Text.Length > 0)
            {
                MessageBox.Show("You need to add a description to the product! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Stock
            if (numericBoxStock.Value == null || numericBoxStock.Value == 0)
            {
                MessageBox.Show("You cannot add a product with stock 0! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Price
            if (numericBoxPrice.Value == null || numericBoxPrice.Value == 0)
            {
                MessageBox.Show("You cannot add a product with price 0! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Color
            if (textBoxColor.Text == null || textBoxColor.Text.Length > 0)
            {
                MessageBox.Show("You need to add a product with color! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Size
            if (comboBoxSize.SelectedValue == null || comboBoxSize.SelectedValue == "") 
            {
                MessageBox.Show("You need to add a product with size! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Categorie
            if (comboBoxCategorie.SelectedValue == null || comboBoxCategorie.SelectedValue == "")
            {
                MessageBox.Show("You need to add a product with categorie! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Image
            if (textBoxImageURL.Text == null || textBoxImageURL.Text.Length > 0)
            {
                MessageBox.Show("You need to add a product with image URL! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Product product = new Product(textBoxName.Text, textBoxImageURL.Text, textBoxDescription.Text, (int)numericBoxStock.Value, (double)numericBoxPrice.Value, textBoxColor.Text, comboBoxSize.SelectedValue.ToString(), comboBoxCategorie.SelectedValue.ToString(), 1);

            try {

                if (ProductId != null)
                {
                    // ProductController.UpdateProduct(product);
                } else {
                    ProductController.AddProduct(product);

                    textBoxName.Text = "";
                    textBoxImageURL.Text = "";
                    textBoxDescription.Text = "";
                    numericBoxStock.Value = 0;
                    numericBoxPrice.Value = 0;
                    textBoxColor.Text = "";
                    comboBoxSize.ResetText();
                    comboBoxCategorie.ResetText();
                }
                

            } catch (Exception ex) {
                MessageBox.Show("Error adding new product! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MainForm(user, "products").Show();
            this.Hide();
        }

        private void navbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
