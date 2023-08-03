
public class ChatMessage
{
    public ChatMessage(string content)
    {
        Id = Guid.NewGuid();
        Content = content;
        SentTime = DateTime.Now;
    }



    public ChatMessage(ChatMessage message)
    {
        Id = message.Id;
        Content = message.Content;
        SentTime = message.SentTime;
        EditedTime = DateTime.Now;
    }



    private string _content;
    public Guid Id { get; }
    public DateTime SentTime { get; set; }
    public DateTime EditedTime { get; set; }
    public string Content
    {
        get => _content;
        set => _content = MessageValidator.IsValidMessage(value)
            ? value
            : throw new ArgumentNullException(nameof(value), "Invalid Message!");
    }


    public override string ToString()
    {
        var time = EditedTime != default(DateTime) ? EditedTime : SentTime;
        return $"{Content} - {time}";
    }


    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }


    public override bool Equals(object? obj)
    {
        if (obj != null && obj is ChatMessage)
            return GetHashCode() == obj.GetHashCode();

        return false;
    }
}