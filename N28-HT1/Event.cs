namespace N28_HT1;

public class Event : IEvent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Event(int id, string name, DateTime date)
    {
        Id = id;
        Name = name;
        Date = date;
    }
}
