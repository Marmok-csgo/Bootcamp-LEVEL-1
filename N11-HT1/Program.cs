namespace N11_HT1;

class Program
{
    static void Main(string[] args)
    {
        var todoList = new ToDoList();

        while (true)
        {

            Console.Write("Choose a command (Display all - d/ Mark Done - m/ Add - a/ Exit - exit: ");
            string Option = Console.ReadLine();

            switch (Option)
            {
                case "d":
                    todoList.Display();
                    break;


                case "m":
                    if (!todoList.Display())
                        break;

                    int taskNum;
                    do
                    {
                        Console.Write("Pick one task: ");
                    } while (!int.TryParse(Console.ReadLine(), out taskNum));

                    var taskN = todoList.MarkDone(taskNum - 1);

                    if (taskN != null)
                        Console.WriteLine($"Task \"{taskN}\" marked as done!");
                    else
                        Console.WriteLine("Task not nound!");
                    break;


                case "a":
                    string task = default;
                    while (true)
                    {
                        Console.Write("Enter task name: ");
                        task = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(task) || task.Length < 4)
                            Console.WriteLine("Invalid Task Name. Try again!");
                        else
                            break;
                    }

                    if (todoList.AddTask(new ToDo(task.Trim())))
                        Console.WriteLine("Task Added Successfully!");
                    else
                        Console.WriteLine("This Task Already Exists!");
                    break;

                case "exit":
                    return;
            }
        }

    }
}