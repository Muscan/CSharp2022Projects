using CRUDWithLoginExample.Classes;
using CRUDWithLoginExample.Controller;
using static CRUDWithLoginExample.Utils.Functions;

namespace CRUDWithLoginExample.Forms
{
    public partial class LoginForm : Form
    {
        private ControllerUser control;
        public static string name, pass;
        public LoginForm()
        {

            InitializeComponent();
            this.control = new ControllerUser();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxUserName) == false)
            {
                MandatoryField("User.");
            }
            else if (IsNotEmpty(txtBoxPassword) == false)
            {
                MandatoryField("Password.");
            }
            else
            {
                LoginForm loginForm = new LoginForm();

                name = txtBoxUserName.Text;

                pass = txtBoxPassword.Text;



                User u = control.returnUser(name, pass, checkBoxIsAdmin.Checked);

                if (u != null)
                {
                    bool admin = control.isUserAdmin(u);
                    if (admin)
                    {

                        frmMain frmMain = new frmMain();

                        frmMain.Show();
                    }
                    else
                    {

                        LoginUserRole frm = new LoginUserRole();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Login does not work, user is admin or does not exist");
                }

            }
            Clear1Field(txtBoxUserName);
            Clear1Field(txtBoxPassword);
            checkBoxIsAdmin.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            if (register.ShowDialog() == DialogResult.OK)
            {
                control.readUserTxt();
            }
        }
    }
}
