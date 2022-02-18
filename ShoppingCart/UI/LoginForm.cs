using ShoppingCart.Classes;
using ShoppingCart.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart.UI
{
    public partial class LoginForm : Form
    {
        private ControllerUser controllerUser;
        public LoginForm()
        {
            InitializeComponent();
            this.controllerUser = new ControllerUser();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "")
            {
                MessageBox.Show("User name mandatory!");
            }
            else if (txtBoxPassword.Text == "")
            {
                MessageBox.Show("Password mandatory ");
            }
            else
            {
                User returnedUser = controllerUser.ReturnUser(int.Parse(txtBoxId.Text), txtBoxUserName.Text, txtBoxPassword.Text, checkBoxIsAdmin.Checked);
                if (returnedUser != null)//user found
                {
                    bool admin = controllerUser.IsUserAdmin(returnedUser);
                    
                    if (admin)
                    {
                        frmAdminForm frmAdminForm = new frmAdminForm();
                        frmAdminForm.Show();
                    }
                    else
                    {
                        ProductsPageForm productsPageForm = new ProductsPageForm();
                        productsPageForm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login does not work, user is admin or does not exist");
                }

               
            }
            txtBoxId.Text = ""; 
            txtBoxUserName.Text = "";
            txtBoxPassword.Text = "";
            checkBoxIsAdmin.Checked = false;
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            if (register.ShowDialog() == DialogResult.OK)
            {
                controllerUser.ReadUserTxt();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
