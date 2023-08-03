
public class ChatService
{
    private readonly HashSet<ChatMessage> _messages = new();
    private readonly Dictionary<Guid, ChatMessage> _idMessages = new Dictionary<Guid, ChatMessage>();



    public Guid Add(string content)
    {
        var message = new ChatMessage(content);
        _messages.Add(message);
        _idMessages[message.Id] = message;

        return message.Id;
    }



    public void Update(Guid id, string content)
    {
        if (!_idMessages.ContainsKey(id))
            throw new ArgumentOutOfRangeException(nameof(id), "Id Not Found!");

        var cpy_message = new ChatMessage(_idMessages[id]);
        cpy_message.Content = content;
        _messages.RemoveWhere(x => x.Id == id);
        _messages.Add(cpy_message);
        _idMessages[id] = cpy_message;
    }



    public void Display()
    {
        foreach (var message in _messages)
            Console.WriteLine(message);

    }
}