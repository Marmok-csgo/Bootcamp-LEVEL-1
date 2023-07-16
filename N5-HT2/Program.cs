Console.Write("Enter a number : ");
var num1 = Convert.ToInt32(Console.ReadLine());
while (true)
{
    Console.Write("Enter a command : ");
    var command = Console.ReadLine();
    
    if(command == "+")
    {
        Console.Write("Enter a number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());
        var Result = num1 + num2;
        Console.WriteLine(Result);
    }
    if (command == "-")
    {
        Console.Write("Enter a number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());
        var Result = num1 - num2;
        Console.WriteLine(Result);
    }
    if (command == "/")
    {
        Console.Write("Enter a number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());
        var Result = num1 / num2;
        Console.WriteLine(Result);
    }
    if (command == "*")
    {
        Console.Write("Enter a number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());
        var Result = num1 * num2;
        Console.WriteLine($"Result : {Result}");
    }
    if (command == "exit" || command == "e")
    {
        Console.WriteLine("Thank you for using calculator");
        break;
    }

}