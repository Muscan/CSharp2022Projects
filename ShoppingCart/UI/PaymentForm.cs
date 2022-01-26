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
        public PaymentForm(double total, List<Product> products)
        {
            InitializeComponent();
            this.products = products;   
            this.total = total;
            controllerUserCard = new ControllerUserCard();
            //controllerUserCard.DisplayUsersCards();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayWithCard_Click(object sender, EventArgs e)
        {
            //search for the User

            int UserIndex = controllerUserCard.ReturnUser(txtBoxName.Text, int.Parse(txtBoxCard.Text));
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
    }
}
