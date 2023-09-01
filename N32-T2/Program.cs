namespace N32_T2;

class Program
{
    static void Main()
    {
        var message1 = new ChatMessage(DateTime.Now,  DateTime.Now.AddDays(2), 1, "Greetings", "Hi there!", 101);
        var message2 = new ChatMessage(DateTime.Now,  DateTime.Now.AddDays(2), 2, "Greetings", "Hi there!", 101);
        
        
        Console.WriteLine($"{message1}\n{message2}");
        
        Console.WriteLine(message1.Equals(message2));
        
        
    }
}