using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace WeatherAPI;

class Program
{
    static void Main(string[] args)
    {
        var client = new HttpClient();
        var apiKey = "6e818e76332207b1216990927bad79d2";
        Console.Write("Enter your city: ");
        var city = Console.ReadLine()!.ToLower();
        string userUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
        var weatherResponse = client.GetStringAsync(userUrl).Result;
        var formattedResponseMain = JObject.Parse(weatherResponse);
        var formattedResponseTemp = formattedResponseMain["main"]?["temp"];
        Console.WriteLine($"{formattedResponseTemp} degrees Fahrenheit.");
    }
}
