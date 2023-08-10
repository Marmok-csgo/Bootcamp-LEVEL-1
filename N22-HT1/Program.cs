namespace N22_HT1;
class Program
{
    static void Main()
    {
        var MarketCard = new KapitalUzcard("8600123443219084", "IpotekaBank", 0);
        var provider = new PaymePaymentProvider();

        var OnlineMarket = new OnlineMarket(provider, MarketCard);
        
        
        OnlineMarket.Add(new Product("Legion_5_Pro", 14_000_000));
        OnlineMarket.Add(new Product("Rog_Strix_G16", 12_000_000));
        OnlineMarket.Add(new Product("HP-OMEN", 9_000_000));


        var MyPersonal = new KapitalUzcard("8600909009094433", "XamkorBank", 29_100_000);
        
        Console.WriteLine(
            OnlineMarket.Buy("HP-OMEN",2, MyPersonal)
            ? "HP-Omen Sotib olindi."
            : "Mahsulot topilmadi yoki balansda yetarli mablag' mavjud emas.");
        
        Console.WriteLine(
            OnlineMarket.Buy("Rog_Scar", 3, MyPersonal)
            ? "Rog_Scar Sotib olindi."
            : "Mahsulot topilmadi yoki balansda yetarli mablag' mavjud emas.");
        
        Console.WriteLine($"Kartada {MyPersonal.Balance}$ qoldi.");



    }
}