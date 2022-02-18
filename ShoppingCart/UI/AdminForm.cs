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
    public partial class frmAdminForm : Form
    {
        private ControllerProduct controller;
        public frmAdminForm()
        {
            InitializeComponent();
            controller = new ControllerProduct();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtBoxIdProduct.Text == "")
            {
                MessageBox.Show("enter product id!");
            }

            else if (txtBoxProductName.Text == "")
            {
                MessageBox.Show("enter product name ");
            }
            else if (txtBoxProductPrice.Text == "")
            {
                MessageBox.Show("enter Price!");
            }
            else
            {
                int productId = int.Parse(txtBoxIdProduct.Text);
                string productName = txtBoxProductName.Text;
                int price = int.Parse(txtBoxProductPrice.Text);

                Product product = new Product(productName, productId, price);
                controller.Add(product);
                controller.SaveToFileProduct();
                txtBoxIdProduct.Text = "";
                txtBoxProductName.Clear();
                txtBoxProductPrice.Clear();
                
                
            }
        }

        private void btnCancelAdminForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm  = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            controller.DisplayProducts(lstViewProducts);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

       

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            ControllerUser user = new ControllerUser();
            user.PrintUsers(lstViewUsers);
        }

        private void lstViewCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControllerUser controllerUser = new ControllerUser();
            if (lstViewUsers.SelectedItems.Count > 0)
            {
                int index = lstViewUsers.SelectedIndices[0];
                
                Card card = controllerUser.returnCard(index);
                lstViewCards.Clear();
                lstViewCards.Columns.Add("Id", 100, HorizontalAlignment.Left);
                lstViewCards.Columns.Add("Amount", 100, HorizontalAlignment.Left);

                ListViewItem line = new ListViewItem();
                line.Text = card.Id.ToString();
                line.SubItems.Add(card.Amount.ToString());

                lstViewCards.Items.Add(line);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstViewProducts.SelectedItems.Count > 0)
            {
                int index = lstViewProducts.SelectedIndices[0];
                controller.RemoveProductFromStock(index);
            }
            else
            {
                MessageBox.Show("Select an item first.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (lstViewProducts.SelectedItems.Count > 0)
            {
                int index = lstViewProducts.SelectedIndices[0];
                controller.RemoveProductFromStock(index);
                controller.DisplayProducts(lstViewProducts);
            }
            else
            {
                MessageBox.Show("Select an item first.");
            }
        }
    }
}
