namespace N15_T1;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3,4,9);

        Console.WriteLine($"S: {triangle.Area}\n" +
            $"P: {triangle.Perimetr}");

    }
}