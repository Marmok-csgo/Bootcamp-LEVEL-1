namespace N23_T1;


class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(322);
        numbers.Add(-1);
        numbers.Add(11);
        numbers.Add(3);
        numbers.Add(6);
        numbers.Add(10);



        var isPositive = numbers.All(num => num > 0);
        Console.WriteLine($"All IsPositive: {isPositive}");

        var isOdd = numbers.Any(num => num % 2 > 0);
        Console.WriteLine($"Is Odd: {isOdd}");

        var haveThreeNine = numbers.Contains(3) && numbers.Contains(9);
        Console.WriteLine($"3 and 9 : {haveThreeNine}");

    }
}

