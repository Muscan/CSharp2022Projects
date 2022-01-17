using ShoppingCart.Controller;
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

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}