namespace N22_HT1;

public class OnlineMarket
{
    
    private readonly IDebitCard _debitCard;
    private readonly IPaymentProvider _provider;
    private List<Product> _products;

    public OnlineMarket(IPaymentProvider provider, IDebitCard MarketCard)
    {
        _provider = provider;
        _debitCard = MarketCard;
        _products = new List<Product>();
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public bool Buy(string name, int number, IDebitCard card)
    {
        foreach (var vaProduct in _products)
        {
            if (vaProduct.Name == name)
            {
                var price = vaProduct.Price * number;
                return _provider.Transfer(card, _debitCard, price);
            }
        }
        return false;
    }
    
    
}