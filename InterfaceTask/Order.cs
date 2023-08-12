namespace InterfaceTask;

public class Order : IOrder
{
    private readonly List<Product> products;

    public Order()
    {
        products = new List<Product>();
    }


    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void PrintOrderDetails()
    {
        foreach (var varProduct in products)
        {
            Console.WriteLine($"Name: {varProduct.Name}\n" +
                              $"Price: {varProduct.Price}$");
        }
    }
}