using ClothesAdmin.Controllers;
using ClothesAdmin.Models;
using System;
using System.Windows.Forms;

namespace ClothesAdmin
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void mainIconLogIn_Click(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            User user = UserController.GetUserByNameAndPassword(usernameTextBoxLogIn.Text, passwordTextBoxLogIn.Text);
            if (user != null)
            {
                this.Hide();
                new MainForm(user).Show();
            }
            else
            {
                MessageBox.Show("The password is incorrect. Please try again.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void panelLogIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        private void mainTitleLogIn_Click(object sender, EventArgs e)
        {

        }
    }
}
