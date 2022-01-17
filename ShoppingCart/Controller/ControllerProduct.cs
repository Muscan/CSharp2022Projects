using ShoppingCart.Classes;

namespace ShoppingCart.Controller
{
    internal class ControllerProduct
    {
        private List<Product> products;
        private List<Product> addedProducts;

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
            String line = "";
            line = read.ReadLine();

            while (line != "" && line != null)
            {
                string[] parts = line.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                int price = int.Parse(parts[2]);
                products.Add(new Product(name, price, id));
                line = read.ReadLine();
            }
            read.Close();
        }

        //Save
        public void SaveToFileProduct()
        {
            StreamWriter write = new StreamWriter(@"../../../Files/AvailableStock.txt");
            write.WriteLine(this.products.ToString());
            write.Close();
        }
        //print products
        public void DisplayProducts(ListView list)
        {
            list.Clear();
            list.Columns.Add("ProductId", 100, HorizontalAlignment.Left);
            list.Columns.Add("Product Name", 100, HorizontalAlignment.Left);
            list.Columns.Add("Price", 100, HorizontalAlignment.Left);
            for (int i = 0; i < products.Count; i++)

            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = products[i].ProductId.ToString();
               // listItem.SubItems.Add(products[i].ProductId.ToString());
                listItem.SubItems.Add(products[i].ProductName);
                listItem.SubItems.Add(products[i].ProductPrice.ToString());
                list.Items.Add(listItem);

            }
        }
       /* public void AddedProducts(ListView list)
        {
            list.Clear();

            list.Columns.Add("ProductId", 100, HorizontalAlignment.Left);
            list.Columns.Add("Product Name", 100, HorizontalAlignment.Left);
            list.Columns.Add("Price", 100, HorizontalAlignment.Left);
            for (int i = 0; i < addedProducts.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = addedProducts[i].ProductId.ToString();
                // listItem.SubItems.Add(products[i].ProductId.ToString());
                listItem.SubItems.Add(addedProducts[i].ProductName);
                listItem.SubItems.Add(addedProducts[i].ProductPrice.ToString());
                list.Items.Add(listItem);
            }

        }*/
        //todo ADDProducts in list
    }
}
