using ShoppingCart.Classes;

namespace ShoppingCart.Controller
{
    internal class ControllerProduct
    {
        private List<Product> products;
        private List<Product> addedProducts;
        private int total;

        public ControllerProduct()
        {
            products = new List<Product>();
            addedProducts = new List<Product>(); 
            ReadProductTxt();
        }

        public bool Add(Product product)
        {
            int index = products.IndexOf(product);
            if (index == -1)
            {
                this.products.Add(product);
                MessageBox.Show("Added product");
                SaveToFileProduct();
                return true;
            }
            return false;
        }
        public void ReadProductTxt()
        {
            StreamReader read = new StreamReader(@"../../../Files/AvailableStock.txt");
            //String line;
            String line = read.ReadLine();

            while (line != "" && line != null)
            {
                string[] parts = line.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                int price = int.Parse(parts[2]);
                products.Add(new Product(name, id, price));
                line = read.ReadLine();
            }
            read.Close();
        }

        public string ToStringObjectProductFile()
        {
            string userDataComplete = "";
            for (int i = 0; i < products.Count; i++)
            {
                userDataComplete += products[i].ToString() + "\n";
            }
            return userDataComplete;
        }
        //Save
        public void SaveToFileProduct()
        {
            StreamWriter write = new StreamWriter(@"../../../Files/AvailableStock.txt");
            write.WriteLine(ToStringObjectProductFile());
            write.Close();
        }
        //print products
        public void DisplayProducts(ListView list)
        {
            list.Clear();
            list.Columns.Add("ProductId", 200, HorizontalAlignment.Left);
            list.Columns.Add("Product Name", 200, HorizontalAlignment.Left);
            list.Columns.Add("Price", 200, HorizontalAlignment.Left);
            for (int i = 0; i < products.Count; i++)

            {
                ListViewItem listItem = new ListViewItem();//Instanitate and call the constructor ListViewItem
                listItem.Text = products[i].ProductId.ToString();
               // listItem.SubItems.Add(products[i].ProductId.ToString());
                listItem.SubItems.Add(products[i].ProductName);
                listItem.SubItems.Add(products[i].ProductPrice.ToString());
                list.Items.Add(listItem);
            }
        }
        public void AddedProducts(ListView list)
        {
            list.Clear();

            list.Columns.Add("ProductId", 150, HorizontalAlignment.Left);
            list.Columns.Add("Product Name", 200, HorizontalAlignment.Left);
            list.Columns.Add("Price", 200, HorizontalAlignment.Left);
            for (int i = 0; i < addedProducts.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = addedProducts[i].ProductId.ToString();
                listItem.SubItems.Add(addedProducts[i].ProductName);
                listItem.SubItems.Add(addedProducts[i].ProductPrice.ToString());
                list.Items.Add(listItem);
            }

        }

        //method for adding products from list to cart
        public void FromListToCart(int index)
        {
            AddProductsCalculate(products[index].ProductPrice);
            addedProducts.Add(products[index]);//add element from the specific index to the addedProducts
            products.RemoveAt(index);
            
        }
        public void RemoveFromCart(int index)
        {
            RemoveProductCalculate(addedProducts[index].ProductPrice);
            products.Add(addedProducts[index]);
            addedProducts.RemoveAt(index);
        }
        
        public int AddProductsCalculate(int addedProduct)
        {
            
            total  += addedProduct;
            return total;
        }
       
        public int RemoveProductCalculate(int removedProduct)
        {
           total -= removedProduct;
           return total;
        }

        public List<Product> GetProducts()
        {
            return addedProducts;
        }
        public int GetTotal()
        {
            return total;
        }
        
        public void RemoveProductFromStock(int index)
        {
            products.RemoveAt(index);
            SaveToFileProduct();
        }
    }
}
