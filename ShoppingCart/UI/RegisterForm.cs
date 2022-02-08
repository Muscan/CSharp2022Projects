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
    public partial class RegisterForm : Form
    {
        private ControllerUser controllerUser;
        public RegisterForm()
        {
            InitializeComponent();
            controllerUser = new ControllerUser();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                MessageBox.Show("User name mandatory!");
            }
            else if (txtBoxPassword.Text == "")
            {
                MessageBox.Show("Password mandatory ");
            }
            //else
            /*{
                
                string registerUser = txtBoxName.Text;
                string registerPassword = txtBoxPassword.Text;
                bool admin = checkBoxIsAdmin.Checked;
                User user = new User(registerUser, registerPassword, admin);
                controllerUser.AddUser(user);
                controllerUser.SaveToFileUserTxt();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }*/
        }
    }
}
