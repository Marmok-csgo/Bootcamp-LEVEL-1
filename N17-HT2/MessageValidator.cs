
public static class MessageValidator
{
    public static bool IsValidMessage(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            return false;

        return true;
    }
}