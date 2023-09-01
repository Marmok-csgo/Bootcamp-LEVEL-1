namespace N32_T3;

public class Product
{
    private string _name;
    private string _description;
    
    public int Id { get; init; }

    public string Name
    {
        get => _name;

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;}
        
    }

    public string Description
    {
        get => _description;
        private set{
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Description cannot be empty.");
            _description = value;}
    }

    public Product(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public Product(Product other)
    {
        Id = other.Id;
        Name = other.Name;
        Description = other.Description;
    }
    
}