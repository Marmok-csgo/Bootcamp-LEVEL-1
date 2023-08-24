namespace TaskAsync;

class Program
{
    static async Task Main(string[] args)
    {
        var service = new TaskService();
        var task1 = new TaskItem(1, "TASK_1");
        var task2 = new TaskItem(2, "TASK_2");

        var check1 = service.AddTaskAsync(task1);
        if (check1)
        {
            service.SaveTaskAsync(task1);
        }

        Console.WriteLine("Task1 added successfully");

        var check2 = service.AddTaskAsync(task2);
        if (check2)
        {
            service.SaveTaskAsync(task2);
            Console.WriteLine("Task1 added successfully");
        }
    }
}