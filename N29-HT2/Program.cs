namespace N29_HT2;

class Program
{
    static async Task Main()
    {
        var employeeService = new EmployeeService();
        Console.Write("Enter a Name: ");
        var name = Console.ReadLine();
        Console.Write("Enter a Surname: ");
        var surname = Console.ReadLine();
        Console.Write("Enter an Email");
        var email = Console.ReadLine();

        await employeeService.HireAsync(name, surname, email);
        Console.Write("_______Success______");
    }
}

