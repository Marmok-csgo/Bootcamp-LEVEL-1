namespace exer_1;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        string[] fruits = { "apple", "banana", "orange", "grape" };

        bool allEven = numbers.All(num => num % 2 == 0);
        Console.WriteLine($"All even: {allEven}");


        bool anyOdd = numbers.Any(num => num % 2 > 0);
        Console.WriteLine($"Any Odd: {anyOdd}");

        bool isHaveBanana = fruits.Contains("banana");
        Console.WriteLine($"Have Banana: {isHaveBanana}");
    }
}

