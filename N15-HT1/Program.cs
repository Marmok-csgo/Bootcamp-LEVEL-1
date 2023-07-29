using N15_HT1;

class Program
{
    static void Main(string[] args)
    {
        var NormalDay = new WeatherReport();
        NormalDay.Add(new DateTime(2023, 11, 8), "Clear skies with bright sunlight, indicating fair weather and high visibility.");
        NormalDay.Add(new DateTime(2023, 9, 10), "Overcast skies with a thick layer of clouds, reducing sunlight and often making it feel cooler.");
        NormalDay.Add(new DateTime(2023, 9, 12), "A mix of clouds and clear skies, providing a balance of sun and shade.");
        NormalDay.Add(new DateTime(2023, 10, 12), "Steady or intermittent rain, indicating precipitation falling from the clouds.");
        NormalDay.Add(new DateTime(2023, 8, 23), "Brief periods of rain with varying intensity, usually followed by clearer skies.");
        NormalDay.Add(new DateTime(2023, 11, 10), "Heavy rain accompanied by thunder, lightning, and sometimes strong winds.");


        Console.WriteLine(NormalDay.Get(new DateTime(2023, 11, 8)));
        Console.WriteLine(NormalDay.Get(new DateTime(2023, 1, 1)));
        Console.WriteLine();

        var NormDay = new ValidatedWeahterReport();
        NormDay.Add(new DateTime(2023, 9, 30), "Falling snowflakes, leading to accumulation of snow on the ground.");
        NormDay.Add(new DateTime(2023, 9, 11), "Intense snowstorms with strong winds and low visibility, often causing dangerous conditions.");
        NormDay.Add(new DateTime(2023, 9, 1), " Low-lying clouds near the ground, reducing visibility significantly.");
        NormDay.Add(new DateTime(2023, 9, 1), "Low-lying clouds near the ground, reducing visibility significantly.");
        NormDay.Add(new DateTime(2023, 9, 2), "Strong gusts of wind, which may cause dust and debris to blow around.");
        NormDay.Add(new DateTime(2023, 9, 3), "High moisture content in the air, making it feel sticky and uncomfortable.");

    }
}