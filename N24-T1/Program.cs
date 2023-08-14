namespace N24_T1;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee { FirstName = "John", LastName = "Doe", Salary = 60000, Kpi = 85 },
            new Employee { FirstName = "Jane", LastName = "Smith", Salary = 55000, Kpi = 78 },
            new Employee { FirstName = "Michael", LastName = "Johnson", Salary = 65000, Kpi = 92 },
            new Employee { FirstName = "Emily", LastName = "Williams", Salary = 58000, Kpi = 75 },
            new Employee { FirstName = "Robert", LastName = "Brown", Salary = 62000, Kpi = 88 },
            new Employee { FirstName = "Jennifer", LastName = "Jones", Salary = 53000, Kpi = 80 },
            new Employee { FirstName = "William", LastName = "Davis", Salary = 67000, Kpi = 89 },
            new Employee { FirstName = "Linda", LastName = "Miller", Salary = 56000, Kpi = 72 },
            new Employee { FirstName = "David", LastName = "Wilson", Salary = 58000, Kpi = 83 },
            new Employee { FirstName = "Karen", LastName = "Moore", Salary = 59000, Kpi = 79 },
            new Employee { FirstName = "James", LastName = "Taylor", Salary = 62000, Kpi = 87 },
            new Employee { FirstName = "Patricia", LastName = "Anderson", Salary = 54000, Kpi = 74 },
            new Employee { FirstName = "Michael", LastName = "Thomas", Salary = 65000, Kpi = 91 },
            new Employee { FirstName = "Barbara", LastName = "Jackson", Salary = 57000, Kpi = 76 },
            new Employee { FirstName = "Christopher", LastName = "White", Salary = 63000, Kpi = 84 },
            new Employee { FirstName = "Jessica", LastName = "Harris", Salary = 55000, Kpi = 82 },
            new Employee { FirstName = "Daniel", LastName = "Martin", Salary = 60000, Kpi = 88 },
            new Employee { FirstName = "Sarah", LastName = "Thompson", Salary = 59000, Kpi = 77 },
            new Employee { FirstName = "Matthew", LastName = "Garcia", Salary = 61000, Kpi = 89 },
            new Employee { FirstName = "Nancy", LastName = "Martinez", Salary = 54000, Kpi = 81 }
        };

        EmployeeService employeeService = new EmployeeService(employees);

        int pageSize = 3;
        int pageToken = 2;
        var pagedEmployees = employeeService.GetBySalary(pageSize, pageToken);

        foreach (var employee in pagedEmployees)
        {
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Salary: {employee.Salary}");
        }
    }
}