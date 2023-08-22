namespace N28_HT2;

public class StorageFile : ICloneable
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public long Size { get; set; }


    public StorageFile(int id, string? name, string? description, long size)
    {
        Id = id;
        Name = name;
        Description = description;
        Size = size;
    }

    public object Clone()
    {
        return new StorageFile(Id, Name, Description, Size);
    }
}