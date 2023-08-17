using N25_HT1.Interface;

namespace N25_HT1.Model;

public class Chair : IProduct
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
    public double MaxWeight { get; set; }
    public string Material { get; set; }

    public Chair(string name, string description, bool isOrdered, double price, double maxWeigth, string material)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Description = description;
        this.IsOrdered = isOrdered;
        this.Price = price;
        this.MaxWeight = maxWeigth;
        this.Material = material;
    }
    
    public Chair(Chair chair)
    {
        this.Id = chair.Id;
        this.Name = chair.Name;
        this.Description = chair.Description;
        this.IsOrdered = chair.IsOrdered;
        this.Price = chair.Price;
        this.MaxWeight = chair.MaxWeight;
        this.Material = chair.Material;
    }
}