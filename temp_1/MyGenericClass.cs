namespace temp_1;

public class MyGenericClass<THing>
{
    private THing _value;

    public MyGenericClass(THing value)
    {
        _value = value;
    }

    public THing GetValue()
    {
        return _value;
    }
}