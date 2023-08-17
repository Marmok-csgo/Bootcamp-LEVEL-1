using N25_HT1.Interface;

namespace N25_HT1.Model;

public class ProductFilterDataModel
{
    public List<string> ProductTypes { get; }

    public ProductFilterDataModel(List<IProduct> products)
    {
        if (products.Count == 0)
            ProductTypes = new();
        else
            ProductTypes = products.Select(item => item.GetType().FullName).Distinct().ToList();
    }
}