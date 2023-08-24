namespace TaskAsync;

public class TaskService
{
    List<TaskItem> _tasks = new List<TaskItem>();


    public bool AddTaskAsync(TaskItem task)
    {
        try
        {
            _tasks.Add(task);
            return true;
        }
        catch
        {
            throw new InvalidOperationException("Task not added!");
        }
    }


    public void CompleteTask(TaskItem task)
    {
        var taskItem = _tasks.Find(t => t.Id == task.Id);
        taskItem.IsCompleted = true;
    }

    public void SaveTaskAsync(TaskItem task)
    {
        var fileName = $"{nameof(task)}.docx";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteAsync($"{task.Id}, {nameof(task)}");
        }
    }
}