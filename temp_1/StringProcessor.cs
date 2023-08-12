namespace temp_1;

public class StringProcessor : IMyGenericInterface<string>
{
    public string Process(string input)
    {
        return input.ToUpper();
    }
}