namespace N22_T3;

public class EventItem : ITaskEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public byte Priority
    {
        get
        {
            if (DateTime.Now > Date)
                return 0;

            var difference = (Date - DateTime.Now).TotalHours;
            if (difference > 5)
                return 0;

            return (byte)(12 - difference * 2);
        }
    }

    public DateTime Date { get; set; }

    public EventItem(string name, DateTime date)
    {
        Id = Guid.NewGuid();
        Name = name;
        Date = date;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Date: {Date:g}";
    }
}