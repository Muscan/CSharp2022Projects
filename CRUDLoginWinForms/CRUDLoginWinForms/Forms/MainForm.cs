using CRUDWithLoginExample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRUDWithLoginExample.Forms;
using CRUDWithLoginExample.Classes;
using static CRUDWithLoginExample.Utils.Functions;

namespace CRUDWithLoginExample.Forms
{
    public partial class frmMain : Form
    {
        ControllerUser control = new ControllerUser();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            control.AfisareUsers(lstUsers);

        }

        private void btnPrintAllUsers_Click(object sender, EventArgs e)
        {
            control.AfisareUsers(lstUsers);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxDeleteUser) == false)
            {
                MandatoryField("User to delete.");
            }
            else
            {
                control.DeleteUser(txtBoxDeleteUser.Text);
                control.AfisareUsers(lstUsers);
                
                //check if the deleted user is the one logged in, user is signed out 
                if(LoginForm.name.Equals(txtBoxDeleteUser.Text))
                {
                    this.Close();
                }
                //Cleans the fields in the text box Delete User
                txtBoxDeleteUser.Clear();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            control.AfisareUsers(lstUsers);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxEditName) == false)
            {
                MandatoryField("User ");
            }
            else if (IsNotEmpty(txtBoxEditPassword) == false)
            {
                MandatoryField("Password ");
            }
            else
            {
                string editUser = txtBoxEditName.Text;
                string editPassword = txtBoxEditPassword.Text;
                bool isAdmin = checkBoxEditIsAdmin.Checked;
                string newName = txtBoxNewName.Text;
                string newPassword = txtBoxNewPassword.Text;

                User usr = new User(editUser, editPassword, isAdmin);
                MessageBox.Show("New user: \"" + newName + "\"\nNew Password: \"" + newPassword + "\"\nIs admin:" + isAdmin); 
                control.updateUser(usr, newName, newPassword);
                if (LoginForm.name.Equals(txtBoxEditName.Text))
                {

                    MessageBox.Show("You will be signed out!");
                    this.Close();

                }
                control.AfisareUsers(lstUsers);
                Clear4Fields(txtBoxEditName, txtBoxEditPassword, txtBoxNewName, txtBoxNewPassword);
                checkBoxEditIsAdmin.Checked = false;


            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            Clear4Fields(txtBoxEditName, txtBoxEditPassword, txtBoxNewName, txtBoxNewPassword);
            checkBoxEditIsAdmin.Checked = false;
            Clear1Field(txtBoxDeleteUser);

        }
    }
}
