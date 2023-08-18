using System.Text.Json;

namespace N25_T1;

class Program
{
    static void Main(string[] args)
    {
        var filePath = @"C:\Users\ferfe\Downloads\Telegram Desktop\AllCountries (2).txt";

        var jFile = File.ReadAllText(filePath);

        var result = JsonSerializer.Deserialize<List<Country>>(jFile);
        Console.Write("Enter the region: ");
        var userInput = Console.ReadLine();
        var SelectedRegion = result.Where(i => i.Region.ToLower().Equals(userInput.ToLower())).ToList();
        Console.Write("Enter the country: ");
        var userInput2 = Console.ReadLine();

        var SelectedCountry = result.Where(i => i.Name.Common.ToLower().Equals(userInput2.ToLower())).ToList();

        foreach (var country in SelectedCountry)
        {
            Console.WriteLine($"{country.Name.Common} - {country.Region}");
        }



    }
}