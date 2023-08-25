namespace CompanyManagement;

public enum Position
{
    Intern,
    Junior,
    Middle,
    Senior,
    TeamLead
}



public class Employee
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Position Position { get; set; }
    public double Salary { get; set; }
    public string? DepartmentName { get; set; }
    public string? No { get; set; }

    public Employee(int id, string? name, string? surname, Position position, double salary, string? departmentName, string? no)
    {
        Id = id;
        FullName = $"{name} {surname}";
        Name = name;
        Surname = surname;
        Position = position;
        Salary = salary;
        DepartmentName = departmentName;
        No = no;
    }
    
    
}