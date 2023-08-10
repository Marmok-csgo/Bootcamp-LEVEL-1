namespace N21_HT1;

public class CustomList<THing>
{
    private readonly int _capacity = 0;
    private THing[] _items;

    public CustomList()
    {
        _items = new THing[_capacity];
    }

    public CustomList(int _size)
    {
        if (_size < 0)
        {
            throw new Exception("array length cannot be less than 0.");
        }
        else if (_size == 0)
        {
            _items = new THing[_capacity];
        }
        else
        {
            _items = new THing[_size];
        }
    }
    
    // Methods

    public void Add(THing item)
    {
        CheckSize();
        _items[_items.Length - 1] = item;
    }

    public void AddRange(params THing[] items)
    {
        foreach (var item in _items)
            Add(item);
    }

    public bool Contains(THing item)
    {
        foreach (var itemQ in _items)
        {
            if (itemQ != null && itemQ.Equals(item))
                return true;
        }

        return false;
    }


    public void CopyTo(THing[] array)
    {
        if (array.Length < _items.Length)
            throw new Exception("length of array is less than length of list.");

        for (int index = 0; index < _items.Length; index++)
        {
            array[index] = _items[index];
        }
    }


    public int IndexOf(THing item)
    {
        for (int index = 0; index < _items.Length; index++)
        {
            if (_items[index].Equals(item))
                return index;
        }

        return -1;
    }

    public void Insert(int index, THing item)
    {
        var newArray = new THing[_items.Length + 1];

        for (int i = 0; i < index; i++)
            newArray[i] = _items[i];

        newArray[index] = item;


        for (int ix = 0; ix < newArray.Length; ix++)
        {
            newArray[ix] = _items[ix - 1];
        }

        _items = newArray;
    }


    public void InsertRange(int index, params THing[] items)
    {
        foreach (var item in items)
        {
            Insert(index, item);
            index++;
        }
    }


    public bool Remove(THing item)
    {
        var newArray = new THing[_items.Length - 1];

        bool isNotFound = true;
        var index = 0;

        for (int ix = 0; ix < _items.Length; ix++)
        {
            if (_items[ix].Equals(item) && isNotFound)
            {
                isNotFound = false;
            }
            else
            {
                newArray[index] = _items[ix];
                index++;
            }
        }

        if (isNotFound)
            return false;
        else
        {
            _items = newArray;
            return true;
        }
    }



    public bool RemoveAt(int index)
    {
        if (index < 0 || index >= _items.Length)
            return false;

        var newArray = new THing[_items.Length - 1];

        bool isNotFound = true;
        var indexQ = 0;
        for (int ind = 0; ind < _items.Length; ind++)
        {
            if (ind == index && isNotFound)
                isNotFound = false;
            else
            {
                newArray[indexQ] = _items[ind];
                indexQ++;
            }

        }

        if (isNotFound)
            return false;
        else
        {
            _items = newArray;
            return true;
        }
    }
    
    public THing[] ToArray()
    {
        return _items;
    }

    public void CheckSize()
    {
        Array.Resize(ref _items, _items.Length + 1);

    }

    public override string ToString()
    {
        var Items = string.Empty;
        foreach (var item in _items)
            Items += item + " ";
        return Items;
    }
}