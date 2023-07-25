namespace N11_HT1;

public class ToDoList
{
    public readonly List<ToDo> _List = new List<ToDo>();
    public readonly List<ToDo> _done = new List<ToDo>();


    public string Exists(int taskNum)
    {
        if (_List.Count > taskNum)
            return _List[taskNum].ToString();

        return null;
    }


    public bool Display()
    {
        if (_List.Count == 0)
        {
            Console.WriteLine("The Tasks is empty!");
            return false;
        }

        for (int i = 0; i < _List.Count; i++)
            Console.WriteLine($"{i + 1}. {_List[i]}");

        Console.WriteLine();
        return true;
    }


    public bool AddTask(ToDo toDo)
    {
        foreach (var task in _List)
            if (string.Equals(task.Task, toDo.Task, StringComparison.OrdinalIgnoreCase))
                return false;


        _List.Add(toDo);
        return true;
    }

    public string MarkDone(int taskNum)
    {
        string task = Exists(taskNum);
        if (task != null)
        {
            _List[taskNum].IsDone = true;
            _done.Add(_List[taskNum]);
            _List.RemoveAt(taskNum);

            return task;
        }

        return null;
    }
}