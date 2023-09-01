namespace N32_T3;

public class ProductService
{
    private List<Product> _products = new List<Product>();
    private static ProductService instance;

    private ProductService() {}

    public static ProductService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ProductService();
            }
            return instance;
        }
    }

    public void Add(int id, string name, string description)
    {
        try
        {
            var product = new Product(id, name, description);
            _products.Add(product);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error adding product: {ex.Message}");
        }
    }

    public Product Clone(int id)
    {
        var existingProduct = _products.Find(p => p.Id == id);
        var clone = new Product(existingProduct);
        _products.Add(clone);
        return clone;
    }

    public void Display()
    {
        foreach (var product in _products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Description: {product.Description}");
        }
    }

}