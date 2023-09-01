namespace N32_T4;

public class Music
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? SingerName { get; set; }

    public Music(int id, string? name, string? singerName)
    {
        Id = id;
        Name = name;
        SingerName = singerName;
    }
}