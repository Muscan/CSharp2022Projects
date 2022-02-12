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
                this.DialogResult = DialogResult.OK;
                
            }
        }
    }
}
