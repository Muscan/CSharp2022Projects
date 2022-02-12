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
    public partial class PaymentForm : Form
    {
        ControllerUserCard controllerUserCard;
        private double total;
        private List<Product> products;
        private Form ProductsPageForm;
        public PaymentForm(double total, List<Product> products, Form ProductsPageForm)
        {
            InitializeComponent();
            this.products = products;   
            this.total = total;
            controllerUserCard = new ControllerUserCard();
            this.ProductsPageForm = ProductsPageForm;
            //controllerUserCard.DisplayUsersCards();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
            ProductsPageForm products =  new ProductsPageForm();
            products.ShowDialog();
        }
        //TODO Remove prodcut from cart after pay is OK
        private void btnPayWithCard_Click(object sender, EventArgs e)
        {
            int UserIndex;
            try
            {
                UserIndex = controllerUserCard.ReturnUser(txtBoxName.Text, int.Parse(txtBoxCard.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Mandatory card id and user");
                return;
            }

            
            if (UserIndex != -1)
            {
                bool amountIsAvailable = controllerUserCard.ReturnBalance(UserIndex, total);
                if (amountIsAvailable)
                {
                    //withrwaw money from account
                    controllerUserCard.PayWithtMoneyFromCard(UserIndex, total);
                    
                    controllerUserCard.SaveToFileAmount();
                    //TBD-refresh balance after click
                    string ProductsInCart = "";
                    for (int i = 0; i < products.Count; i++)
                    {
                        ProductsInCart += products[i].ProductName +'-'+ products[i].ProductPrice +" Ron\n";
                    }

                    MessageBox.Show("Transaction succeded!\n" + "Total " +  total + '\n' + ProductsInCart );

                }
                else
                {
                    MessageBox.Show("Not enough money");
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void btnBackToCart_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductsPageForm.Visible = true;

        }
    }
}
