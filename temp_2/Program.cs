namespace temp_2;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };

        var evenNumbers = from num in numbers
            where num % 2 == 0
            select num;

        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
    }
}