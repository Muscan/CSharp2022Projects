namespace ShoppingCart.Classes
{
    internal class Product
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int ProductPrice { get; set; }
        public Product()
        {

        }

        public Product(string productName, int productId, int productPrice)
        {
            this.ProductName = productName;
            this.ProductId = productId;
            this.ProductPrice = productPrice;
            
        }
        
        public override String ToString()
        {
            return ProductName + "," + ProductId + "," + ProductPrice;
        }
        
        

    }
}
