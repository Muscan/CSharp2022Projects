using CRUDWithLoginExample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRUDWithLoginExample.Classes;
using static CRUDWithLoginExample.Utils.Functions;

namespace CRUDWithLoginExample.Forms
{
    public partial class LoginUserRole : Form
    {
        ControllerUser control = new ControllerUser();
        public LoginUserRole()
        {
            InitializeComponent();
            //display the name of the logged user
            lblUser.Text = "Welcome, " + LoginForm.name + "!";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnEditLoggedUser_Click(object sender, EventArgs e)
        {

            if (IsNotEmpty(txtBoxNewName) == false)
            {
                MandatoryField("New User Name! ");
            }
            else if (IsNotEmpty(txtBoxNewPassword) == false)
            {
                MandatoryField("New Password! ");
            }
            else
            {
                string updateName = txtBoxNewName.Text;
                string updatePassword = txtBoxNewPassword.Text;
                //Params for the object userRole are token from the Main Login form. 
                User userRole = new User(LoginForm.name, LoginForm.pass);
                control.updateUser(userRole, updateName, updatePassword);
                Clear2Fields(txtBoxNewName, txtBoxNewPassword);
                MessageBox.Show("Name: \""+updateName+"\" and Password: \"" + updatePassword+ "\" were updated.\n"+ "You will be signed out!");
                this.Close();

            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            Clear1Field(txtBoxNewName);
            Clear1Field(txtBoxNewPassword);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
