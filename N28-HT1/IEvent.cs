namespace N28_HT1;

public interface IEvent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
}