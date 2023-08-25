namespace CompanyManagement;

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    
    public int WorkerLimit { get; set; }
    public double SalaryLimit { get; set; }
    private List<Employee> _employees;


    public Department(int id, string? name, int workerLimit, double salaryLimit)
    {
        Id = id;
        Name = name;
        WorkerLimit = workerLimit;
        SalaryLimit = salaryLimit;
    }
}