using ShoppingCart.Controller;
using ShoppingCart.UI;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        ControllerProduct controller;  
        public Form1()
        {
            InitializeComponent();
            controller = new ControllerProduct();
            controller.DisplayProducts(lstViewProducts);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using fullRowSelect for the list view in order to be clickable
            try
            {
                controller.FromListToCart(lstViewProducts.SelectedItems[0].Index);//check something is selected
                controller.AddedProducts(lstViewCart);
                controller.DisplayProducts(lstViewProducts);
                lblTotal.Text = "Subtotal: " + controller.GetTotal();
            }
            catch(ArgumentOutOfRangeException exception) {
                MessageBox.Show("No item selected. Please select one");
            };
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm =new PaymentForm(controller.GetTotal());
            paymentForm.Show();
        }

        private void lstViewProducts_SelectedIndexChanged(object sender, EventArgs e)
            //list with the elements on the product
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                controller.RemoveFromCart(lstViewCart.SelectedItems[0].Index);
                controller.AddedProducts(lstViewCart);
                controller.DisplayProducts(lstViewProducts);
                lblTotal.Text = "Subtotal: " + controller.GetTotal();
            }
            catch (Exception)
            {

                MessageBox.Show("No item selected.Please select one");
            }
            
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }
    }
}