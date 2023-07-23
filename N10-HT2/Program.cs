using System;
using System.Collections.Generic;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class ShoppingCart
{
    public List<Product> Items { get; set; }

    public ShoppingCart()
    {
        Items = new List<Product>();
    }

    public void Add(Product product)
    {
        Product existingProduct = Items.Find(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
        }
        else
        {
            Items.Add(product);
        }
    }

    public bool Remove(Product product)
    {
        Product existingProduct = Items.Find(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            Items.Remove(existingProduct);
            return true;
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product { Id = 1, Name = "Ko'k ko'ylak" };
        Product product2 = new Product { Id = 2, Name = "Qora palto" };
        Product product3 = new Product { Id = 3, Name = "Oq yubka" };

        ShoppingCart cart = new ShoppingCart();

        cart.Add(product1);
        cart.Add(product2);
        cart.Add(product3);

        Console.WriteLine("Korzinka mahsulotlari:");
        foreach (var item in cart.Items)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
        }

        cart.Remove(product2);

        Console.WriteLine("\nKorzinka holati mahsulot olindi:");
        foreach (Product item in cart.Items)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
        }
    }
}
