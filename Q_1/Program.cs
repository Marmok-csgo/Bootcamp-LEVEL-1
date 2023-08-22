namespace Q_1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>{1, 2, 3, 4, 5, 6, 7};
        numbers.Add(4);
        
        
        int sum = numbers.Sum();
        Console.WriteLine($"Sum: {sum}");

        List<double> squaredNumbers = numbers.Select(num => Math.Pow(num, 2)).ToList();
        Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));
        
        List<int> duplicateNumbers = new List<int>{1, 2, 3, 3, 4};
        List<int> disticntNumbers = duplicateNumbers.Distinct().ToList();
        
        Console.WriteLine("Distinct numbers: " + string.Join(", ", disticntNumbers));
        
    }
}