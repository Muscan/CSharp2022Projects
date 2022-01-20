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
        public PaymentForm(double total)
        {
            InitializeComponent();
            this.total = total;
            controllerUserCard = new ControllerUserCard();
            //controllerUserCard.DisplayUsersCards();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPatWithCard_Click(object sender, EventArgs e)
        {
            //search for the User

            UserCard userCardPayment = controllerUserCard.ReturnUser(txtBoxName.Text, int.Parse(txtBoxCard.Text));
            if (userCardPayment != null)
            {
                bool amountIsAvailable = controllerUserCard.ReturnBalance(userCardPayment, total);
                if (amountIsAvailable)
                {
                    //withrwaw money from account
                    controllerUserCard.PayWithtMoneyFromCard(userCardPayment, total);
                    MessageBox.Show("Transaction succeded");
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
