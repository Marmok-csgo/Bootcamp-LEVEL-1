Console.Write($"Enter a age: ");
var age = Convert.ToInt32(Console.ReadLine());

try
{
    if(age < 18)  
    {
        throw new ArgumentOutOfRangeException("Sorry, you are too young");
    }
    if(age > 90)
    {
        throw new ArgumentOutOfRangeException("Sorry, you are too old");
    }
    else
    {
        Console.WriteLine("Valid age");
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}