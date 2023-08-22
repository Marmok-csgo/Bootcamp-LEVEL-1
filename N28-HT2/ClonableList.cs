namespace N28_HT2;

public class ClonableList<T> : List<T> where T : ICloneable
{
    public ClonableList() : base(){}
    
    public ClonableList(IEnumerable<T> collection) : base(collection){}

    public ClonableList<T> Clone()
    {
        ClonableList<T> clone = new ClonableList<T>();
        foreach (T item in this)
        {
            clone.Add((T)item.Clone());
        }
        return clone;
    }
}