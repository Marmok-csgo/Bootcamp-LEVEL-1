namespace N26_T1;

public class Meeting
{
    public string? Name { get; set; }
    public TimeSpan Duration { get; set; }


    public Meeting(string? name, TimeSpan duration)
    {
        Name = name;
        Duration = duration;
    }

    public static Meeting operator +(Meeting s1, Meeting s2)
    {
        return new Meeting($"Combined: {s1.Name} & {s2.Name}", s1.Duration + s2.Duration);
    }
}