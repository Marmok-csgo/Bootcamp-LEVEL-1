namespace N24_T1;

public class EmployeeService
{
    private List<Employee> employees;

    public EmployeeService(List<Employee> employees)
    {
        this.employees = employees;
    }

    public IEnumerable<Employee> GetBySalary(int pageSize, int pageToken)
    {
        var sortedEmployees = employees.OrderBy(emp => emp.Salary);

        var pagedEmployees = sortedEmployees
            .Skip((pageToken - 1) * pageSize)
            .Take(pageSize);

        return pagedEmployees;
    }
}