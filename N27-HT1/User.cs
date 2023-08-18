namespace N27_HT1;

public class User
{
    public Guid Id { get; set; }
    public string? EmailAddress { get; set; }
    public string? Password { get; set; }
    public bool IsAdmin { get; set; }


    public User(string? emailAddress, string password, bool isAdmin = false)
    {
        Id = Guid.NewGuid();
        EmailAddress = emailAddress;
        Password = password;
        IsAdmin = isAdmin;
    }
}