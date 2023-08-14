namespace exer_2;


class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Alice", 28),
            new Employee(2, "Bob", 35),
            new Employee(3, "Charlie", 22),
            new Employee(4, "David", 40)
        };

        Employee firstSenior = employees.First(emp => emp.Age > 30);
        Console.WriteLine($"First employee above 30: {firstSenior.Name}");

        Employee lastJunior = employees.Last(emp => emp.Age < 25);
        Console.WriteLine($"Last employee below 25: {lastJunior.Name}");

        Employee employeeWithId3 = employees.Single(emp => emp.Id == 3);
        Console.WriteLine($"Employee with ID 3: {employeeWithId3.Name}");

        bool anyUnder21 = employees.Any(emp => emp.Age < 21);
        Console.WriteLine($"Any under 21: {anyUnder21}");

        bool containsBob = employees.Select(emp => emp.Name).Contains("Bob");
        Console.WriteLine($"Contains an employee named Bob: {containsBob}");

    }
}