namespace InterfaceTask;

public class Product : IProduct
{
    public string? Name { get; set; }
    public int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}