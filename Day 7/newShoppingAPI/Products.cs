namespace newShoppingAPI
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        //create properties for the product class ProductIsInStock, ProductCategory
        public bool ProductIsInStock { get; set; }
        public string ProductCategory { get; set; }


        //create a  static list of products variable with 10 sample data
        public static List<Products> products = new List<Products>()
        {
            new Products(){Id=1, ProductName="Milk", ProductPrice=10, ProductIsInStock=true, ProductCategory="Dairy"},
            new Products(){Id=2, ProductName="Bread", ProductPrice=20, ProductIsInStock=true, ProductCategory="Bakery"},
            new Products(){Id=3, ProductName="Eggs", ProductPrice=30, ProductIsInStock=true, ProductCategory="Dairy"},
            new Products(){Id=4, ProductName="Butter", ProductPrice=40, ProductIsInStock=true, ProductCategory="Dairy"},
            new Products(){Id=5, ProductName="Cheese", ProductPrice=50, ProductIsInStock=true, ProductCategory="Dairy"},
            new Products(){Id=6, ProductName="Cake", ProductPrice=60, ProductIsInStock=true, ProductCategory="Bakery"},
            new Products(){Id=7, ProductName="Biscuits", ProductPrice=70, ProductIsInStock=true, ProductCategory="Bakery"},
            new Products(){Id=8, ProductName="Cupcakes", ProductPrice=80, ProductIsInStock=true, ProductCategory="Bakery"},
            new Products(){Id=9, ProductName="Pies", ProductPrice=90, ProductIsInStock=true, ProductCategory="Bakery"},
            new Products(){Id=10, ProductName="Scones", ProductPrice=100, ProductIsInStock=true, ProductCategory="Bakery"}
        };

        //create a method to return all the products
        public static List<Products> GetAllProducts()
        {
            return products;
        }

        //create a method to return a single product based on the id
        public static Products GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        //create a method to add a new product
        public static void AddProduct(Products product)
        {
            products.Add(product);
        }

        //create a method to update a product
        public static void UpdateProduct(Products product)
        {
            Products p = products.FirstOrDefault(p => p.Id == product.Id);
            p.ProductName = product.ProductName;
            p.ProductPrice = product.ProductPrice;
            p.ProductIsInStock = product.ProductIsInStock;
            p.ProductCategory = product.ProductCategory;
        }

        //create a method to delete a product   
        public static void DeleteProduct(int id)
        {
            Products p = products.FirstOrDefault(p => p.Id == id);
            products.Remove(p);
        }

        

    }    
}