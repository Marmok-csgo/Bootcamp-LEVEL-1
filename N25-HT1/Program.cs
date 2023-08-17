using N25_HT1.Model;
using N25_HT1.Service;
using Monitor = N25_HT1.Model.Monitor;

namespace N25_HT1;

class Program
{
    static void Main(string[] args)
    {var productService = new ProductService();
        var paymentService = new PaymentService();

        var orderService = new OrderService(productService, paymentService);

//add monitors
        var m1 = new Monitor("Monitor-1", "FullHD", false, 1_500_000, 20, 144); ;
        productService.Add(m1);

        var m2 = new Monitor("Monitor-2", "4K", false, 1_750_000, 18, 120); ;
        productService.Add(m2);

        var m3 = new Monitor("Monitor-3", "OLED", false, 1_000_000, 10, 144); ;
        productService.Add(m1);

        var m4 = new Monitor("Monitor-4", "FullHD_4K", false, 1_050_000, 18, 120); ;
        productService.Add(m2);

// add laptops
        var l1 = new Laptop("HP", "Black", false, 5_000_000, "ryzen", "amd");
        productService.Add(l1);

        var l2 = new Laptop("Asus", "White", false, 6_000_000, "intel", "core");
        productService.Add(l2);

        var l3 = new Laptop("Victus", "Grey", false, 7_000_000, "ryzen5", "amd");
        productService.Add(l3);

// add chairs
        var ch1 = new Chair("METAL_CHAIR", "GREY_WHITE", false, 250_000, 10, "nimadir");
        productService.Add(ch1);

        var ch2 = new Chair("WOOD_CHAIR", "TREE_BLUE", false, 300_000, 13, "nimadir");
        productService.Add(ch2);
        var ch3 = new Chair("GOLD_CHAIR", "YELLOW_CC", false, 350_000, 15, "nimadir");
        productService.Add(ch3);

        Console.WriteLine("Hozirda mavjud tiplar: ");
        productService.GetFilterData().ProductTypes.ForEach(Console.WriteLine);

        var myCard = new DebitCard { CardNumber = "760000098000", Balance = 100_000_000 };

        Console.WriteLine("balance: " + myCard.Balance);

        if (orderService.Order(ch1.Id, myCard))
            Console.WriteLine("Sotib olindi");
        else
        {
            Console.WriteLine("Xatolik");
        }

        Console.WriteLine("balance: " + myCard.Balance);
    }
}

