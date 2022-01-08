using CRUDWithLoginExample.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRUDWithLoginExample.Controller;
using static CRUDWithLoginExample.Utils.Functions;

namespace CRUDWithLoginExample.Forms
{
    public partial class RegisterForm : Form
    {
        private ControllerUser controlUser;
        public RegisterForm()
        {
            InitializeComponent();
            controlUser = new ControllerUser();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxName) == false)
            {
                MandatoryField("Name!");
            }
            else if (IsNotEmpty(txtBoxPassword) == false)
            {
                MandatoryField("Password!");
            }
            else
            {
                RegisterForm registerForm = new RegisterForm();
                frmMain frm = new frmMain();
                
                string registerUser = txtBoxName.Text;
                string registerPassword = txtBoxPassword.Text;
                bool admin = checkBoxIsAdmin.Checked;
                User user = new User(registerUser, registerPassword, admin);
                controlUser.Add(user);
                controlUser.saveToFileUserTxt();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
