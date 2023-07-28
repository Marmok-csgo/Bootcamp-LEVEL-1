using System.Diagnostics.Contracts;
var messager = new NotificationMessages();
Console.WriteLine(messager.SearchMessage("AskPassword")); 
Console.WriteLine(messager.SearchMessage("Tournament starts Tomorrow"));



public class NotificationMessages
{
    private Dictionary<string, string> MessageDict = new Dictionary<string, string>();

    public NotificationMessages()
    {
        MessageDict.Add("SuccRegistration", "You successfully registered");
        MessageDict.Add("AskPassword", "Enter your password");
        MessageDict.Add("Blocked", "Your account has been blocked");
    }
    protected KeyValuePair<string, string> FindMessage(string messageName)
    {
        foreach (var message in MessageDict)
        {
            if (message.Key.ToLower().Contains(messageName.ToLower()))
                return message;
        }
        var notFound = new KeyValuePair<string, string>("NotFound", "Message topilmadi");
        return notFound;
    }

    public string SearchMessage(string messageName)
    {
        return FindMessage(messageName).Value;
    }
}