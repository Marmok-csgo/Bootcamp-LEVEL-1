using N17_HT1;

class Program
{
    static async Task Main(string[] args)
    {
        var rent = new CarRentalManagement();
        var ix = new BMW("Ix");
        var x5 = new BMW("X5");
        var x7 = new BMW("X7");

        var a6 = new Audi("A6");
        var r8 = new Audi("R8");
        var a8 = new Audi("A8");


        rent.Add(ix);
        rent.Add(x5);
        rent.Add(x7);

        rent.Add(a6);
        rent.Add(r8);
        rent.Add(a8);

        var rentcar1 = rent.Rent("Ix");
        if (rentcar1 != null)
        {
            await Task.Delay(1000);
            rent.Return(rentcar1);
        }

        var rentcar2 = rent.Rent("R8");
        if (rentcar2 != null)
        {
            await Task.Delay(4000);
            rent.Return(rentcar2);
        }

        Console.WriteLine(rent.CalculateBalance().ToString("C"));
    }
}