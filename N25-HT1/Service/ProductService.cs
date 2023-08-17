using N25_HT1.Interface;
using N25_HT1.Model;
using Monitor = N25_HT1.Model.Monitor;

namespace N25_HT1.Service;

public class ProductService
{
    private List<IProduct> _inventory { get; set; }

    public ProductService()
    {
        _inventory = new List<IProduct>();
    }

    public void Add(IProduct product) => _inventory.Add(product);

    public ProductFilterDataModel GetFilterData() => new ProductFilterDataModel(_inventory);

    public List<IProduct> Get(ProductFilterDataModel filterModel)
    {
        var filter = _inventory.Where(item => filterModel.ProductTypes.Contains(item.GetType().FullName)).ToList();
        var result = new List<IProduct>(filter);
        return result;
    }

    public IProduct Order(Guid productId)
    {
        var result = _inventory.Find(product => product.Id == productId);
        result.IsOrdered = true;
        return CopyProduct(result) is null
            ? throw new Exception("Product not found")
            : CopyProduct(result);

    }

    public IProduct Return(Guid productId)
    {
        var result = _inventory.Find(p => p.Id == productId);
        result.IsOrdered = false;
        return CopyProduct(result) is null
            ? throw new Exception("Product not found")
            : CopyProduct(result);

    }


    private IProduct CopyProduct(IProduct product)
    {
        if (product is Monitor monitor)
        {
            var obj = new N25_HT1.Model.Monitor(monitor);
            return obj;
        }
        else if (product is Chair chair)
        {
            var obj = new Chair(chair);
            return obj;
        }
        else if (product is Laptop laptop)
        {
            var obj = new Laptop(laptop);
            return obj;
        }
        return null;
    }
}