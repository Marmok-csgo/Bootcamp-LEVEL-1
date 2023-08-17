namespace N25_HT1.Interface;

public interface IProduct
{
    Guid Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    bool IsOrdered { get; set; }
    double Price { get; set; }
}