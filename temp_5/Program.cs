namespace temp_5;

class Program
{
    static void Main()
    {
        List<Product> products = GetProducts();

        decimal minPrice = 50.0m;

        var expebsiveProducts = products.Where(product => product.Price > minPrice);

        foreach (var product in expebsiveProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price}$");
        }
    }


    static List<Product> GetProducts()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Product_1", Price = 75.0m},
            new Product{Name = "Product_2", Price = 120.0m},
            new Product{Name = "Product_3", Price = 50.0m},
            new Product{Name = "Product_5", Price = 66.6m},
            new Product{Name = "Product_6", Price = 77.0m}
        };

        return products;
    }
}