using System.Diagnostics;
using System.Text.RegularExpressions;
using N32_T5;

internal class Program
{
    private static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        stopwatch.Start();
        for (var index = 0; index < 100_000; index += 100)
            CustomValidator.IsValidEmailAddress(null, regex);
        stopwatch.Stop();
        Console.WriteLine($"Null Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Restart();

        for (var index = 0; index < 100_000; index += 100)
            CustomValidator.IsValidEmailAddress("", regex);
        stopwatch.Stop();
        Console.WriteLine($"Empty Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Restart();

        for (var index = 0; index < 100_000; index += 100)
            CustomValidator.IsValidEmailAddress("test.co@m", regex);
        stopwatch.Stop();
        Console.WriteLine($"Invalid Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
    }
}

