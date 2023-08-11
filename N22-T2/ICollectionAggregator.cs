var aggregator = null as ICollectionAggregator;
aggregator = new CollectionAggregator();

var listA = new List<int>
{
    1,
    2,
    3
};

var listB = new List<int>
{
    2,
    4,
    5
};

// aggregator = new NewCollectionAggregator();

Console.Write("Concat result : ");
aggregator.Concat(listA, listB).ForEach(Console.Write);
Console.WriteLine();

Console.Write("Intersect result : ");
aggregator.Intersect(listA, listB).ForEach(Console.Write);
Console.WriteLine();

Console.Write("Exept result : ");
aggregator.Except(listA, listB).ForEach(Console.Write);
Console.WriteLine();

Console.Write("Union result : ");
aggregator.Union(listA, listB).ForEach(Console.Write);

public interface ICollectionAggregator
{
    List<T> Concat<T>(in List<T> listA, in List<T> listB);

    List<T> Intersect<T>(in List<T> listA, in List<T> listB);

    List<T> Except<T>(in List<T> listA, in List<T> listB);

    List<T> Union<T>(in List<T> listA, in List<T> listB);
}

public class CollectionAggregator : ICollectionAggregator
{
    public List<T> Concat<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        list.AddRange(listA);
        list.AddRange(listB);

        return list;
    }

    public List<T> Intersect<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        foreach (var itemA in listA)
            if (listB.Contains(itemA))
                list.Add(itemA);

        return list;
    }

    public List<T> Except<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        foreach (var itemA in listA)
            if (!listB.Contains(itemA))
                list.Add(itemA);

        return list;
    }

    public List<T> Union<T>(in List<T> listA, in List<T> listB)
    {
        var lisT = new List<T>();
        lisT.AddRange(listA);
        lisT.AddRange(listB);

        List<T> distinct = lisT.Distinct().ToList();
        return distinct;
    }
}

// Yangi usulni tushuntirish uchun
public class NewCollectionAggregator : ICollectionAggregator
{
    public List<T> Concat<T>(in List<T> listA, in List<T> listB)
    {
        // throw new NotImplementedException();
    }

    public List<T> Intersect<T>(in List<T> listA, in List<T> listB)
    {
        // throw new NotImplementedException();
    }

    public List<T> Except<T>(in List<T> listA, in List<T> listB)
    {
        // throw new NotImplementedException();
    }

    public List<T> Union<T>(in List<T> listA, in List<T> listB)
    {
        // throw new NotImplementedException();
    }
}