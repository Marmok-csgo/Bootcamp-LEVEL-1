namespace Temp_3;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Orange",
            "Mango",
            "Grapes"
        };

        var selectedFruits = fruits.Where(frit => frit.Length > 5);

        foreach (var fruit in selectedFruits)
        {
            Console.Write(fruit + " ");
        }
    }
}