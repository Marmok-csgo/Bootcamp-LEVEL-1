namespace temp_1;

public class Program
{
    public THing GetMax<THing>(THing a, THing b) where THing : IComparable<THing>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }


    public static void Main()
    {
        var intContainer = new MyGenericClass<int>(42);
        int intValue = intContainer.GetValue();
        
        Console.WriteLine($"Value from int container: {intValue}");

        var stringContainer = new MyGenericClass<string>("Hello, Generics!");
        string strValue = stringContainer.GetValue();
        
        Console.WriteLine($"Value from string container: {strValue}");


        var stringProcess = new StringProcessor();
        string processedStr = stringProcess.Process("Generic interfaces");
        
        Console.WriteLine($"Processed string: {processedStr}");


        Program program = new Program();

        int maxInt = program.GetMax(10, 20);
        double maxDouble = program.GetMax(3.14, 1.456);
        string maxString = program.GetMax("apple", "banana");
        
        
        Console.WriteLine($"Max int: {maxInt}\n" +
                          $"Max double: {maxDouble}\n" +
                          $"Max string: {maxString}");

        Pair<int, string> pair = new Pair<int, string>();
        pair.First = 42;
        pair.Second = "Hello, generics!";
        Console.WriteLine($"Pair - First: {pair.First}\n" +
                          $"Pair - Second: {pair.Second}");

    }
}
