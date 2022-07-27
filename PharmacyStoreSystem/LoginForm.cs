using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStoreSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ClearField_Click(object sender, EventArgs e)
        {
            UserName.Clear();
            UserPassword.Clear();
            UserName.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserName.Text == "admin" && UserPassword.Text == "admin")
            {
                MessageBox.Show("Login Successful.");
                MainMenuForm main = new MainMenuForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password !");
                UserName.Clear();
                UserPassword.Clear();
                UserName.Focus();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
