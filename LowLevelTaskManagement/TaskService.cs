namespace LowLevelTaskManagement;

public class TaskService
{
    private List<Task> _tasks = new List<Task>();

    
    public List<Task> GetT()
    {
        return _tasks;
    }
    public void AddTask(Task task)
    {
        _tasks.Add(task);
        
    }

    public void CompleteTask(int taskId)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        if (task!= null)
        {
            task.IsCompleted = true;
        }
    }

    public List<Task> GetTasks(Priority priority)
    {
         var result = _tasks.Where(u => u.Priority == priority).ToList();
         return result;
    }
    
}