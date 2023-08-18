namespace LowLevelTaskManagement;

public enum Priority
{
    Low,
    Medium,
    High
}
public class Task
{
    public int Id { get; set; }
    public Priority Priority { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }

    public Task(int id, Priority priority, DateTime deadline)
    {
        Id = id;
        Priority = priority;
        Deadline = deadline;
        IsCompleted = false;
        CreatedDate = DateTime.Now;
    }
}