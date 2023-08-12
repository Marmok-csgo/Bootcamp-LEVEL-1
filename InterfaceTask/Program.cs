namespace InterfaceTask;
class Program
{
    static void Main()
    {
        var order = new Order();
        var product1 = new Product("Legion_5_Pro", 1400);
        var produvt2 = new Product("HP_OMEN", 900);
        
        order.AddProduct(product1);
        order.AddProduct(produvt2);
        
        order.PrintOrderDetails();
    }
}