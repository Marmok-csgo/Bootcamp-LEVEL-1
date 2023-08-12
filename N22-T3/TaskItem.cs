namespace N22_T3;

public class TaskItem : ITaskEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    private byte _priority;
    public byte Priority
    {
        get => _priority;
        private init
        {
            if(value >= 1 && value <= 10)
            {
                _priority = value;
            }
        }
    }

    public TaskItem(string name, string description, byte priority)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Description: {Description}, Priority: {Priority}";
    }
}