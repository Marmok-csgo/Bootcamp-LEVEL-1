namespace N32_T2;

public class ChatMessage : AuditableEntity
{
    public int Id { get; set; }
    public string? Subject {get; set; }
    public string? Message { get; set; }
    public int ChatId { get; set; }

    public ChatMessage(DateTime createdDate, DateTime modifieldDate, int id, string? subject, string? message, int chatId) : base(createdDate, modifieldDate)
    {
        Id = id;
        Subject = subject;
        Message = message;
        ChatId = chatId;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Subject, Message);
    }

    public override bool Equals(object? obj)
    {
        var other = (ChatMessage)obj;
        return Id == other.Id && Subject == other.Subject && Message == other.Message;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Subject: {Subject}, Message: {Message}, ChatId: {ChatId}, createdDate: {CreatedDate}, modifieldDate: {ModifieldDate}";
    }
}