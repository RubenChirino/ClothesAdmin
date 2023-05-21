using ClothesAdmin.Classes;
using ClothesAdmin.Controllers;
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
    public partial class SaleForm : Form
    {

        public User user;
        private int SaleId;

        public SaleForm(User user, int saleId)
        {
            this.user = user;
            this.SaleId = saleId;

            InitializeComponent();

            // Elements
            comboBoxClientDNI.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxClientDNI.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientDNI.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Data
            SetProductOptions();
            SetClientOptions();
        }

        public void SetProductOptions() 
        {
            List<Product> products = ProductController.GetProducts();
            int totalProducts = products.Count;
            string[] productOptions = new string[totalProducts];
            int internalCounter = 0;

            for (int i = 0; i < totalProducts; i++)
            {
                Product product = products[i];
                if (product.IsActive == 1 && product.Stock >= 1)
                {
                    int id = product.Id;
                    string name = product.Name;
                    string option = $"{id} - {name}";
                    productOptions[internalCounter] = option;
                    internalCounter++;
                }
            }
            comboBoxProduct.DataSource = productOptions;
        }

        public void SetClientOptions()
        {
            List<Client> clients = ClientController.GetClients();
            int totalClients = clients.Count;
            string[] clientOptions = new string[totalClients];
            for (int i = 0; i < totalClients; i++)
            {
                Client client = clients[i];
                // string email = client.Email;
                string dni = client.DNI;

                string option = $"{dni}";
                clientOptions[i] = option;
            }
            comboBoxClientDNI.DataSource = clientOptions;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            
        }

        // Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            new MainForm(user, "sales").Show();
            this.Hide();
        }

        private void panelInputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxClientDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado o ingresado por el usuario
            string selectedValue = comboBoxClientDNI.SelectedValue?.ToString();
            string textValue = comboBoxClientDNI.Text;
            string dni = (comboBoxClientDNI.SelectedValue?.ToString() != null) ? selectedValue : textValue;

            // Validations

            // Product
            if (comboBoxProduct.SelectedValue == null || comboBoxProduct.SelectedValue == "")
            {
                MessageBox.Show("You need to add a product! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Client
            if (dni == null || dni == "")
            {
                MessageBox.Show("You need to add a DNI! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int clientId = -1;

            try
            {
                Client client = ClientController.GetClientByDNI(dni);
                if (client != null)
                {
                    clientId = client.Id;
                }
                else
                {
                    Client newClient = new Client(dni, null);
                    clientId = ClientController.AddClient(newClient);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting the Client data! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product;
            int productId = -1;
            double total = -1;

            try
            {
                productId = int.Parse(comboBoxProduct.SelectedValue.ToString().Split('-')[0].Trim());
              
                if (productId != null)
                {
                    product = ProductController.GetProductById(productId);
                    total = product.Price;
                }
                else
                {
                    throw new Exception("productId not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting the product data! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sale sale;

            if (productId != -1 && clientId != -1 && total != -1) {
                sale = new Sale(productId, user.Id, clientId);
            } else
            {
                MessageBox.Show("Error in the sale creation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("¿Are you sure to add the new sale?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaleController.AddSale(sale, total);
                    comboBoxClientDNI.ResetText();
                    comboBoxProduct.ResetText();

                    // Reduce Stock form product
                    product.Stock -= 1;
                    ProductController.UpdateProduct(productId, product);

                    // Reload product options
                    SetProductOptions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the sale Form! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
