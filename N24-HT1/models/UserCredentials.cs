namespace N24_HT1.models;

public class UserCredentials
{
    public Guid Id { get; set; }
    public string? Password { get; set; }
    public Guid UserId { get; set; }

    public UserCredentials(string? password, Guid userId)
    {
        Id = Guid.NewGuid();
        Password = password;
        UserId = userId;
    }
}