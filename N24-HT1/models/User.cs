namespace N24_HT1.models;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public bool IsDeleted { get; set; }

    public User(string firstName, string lastName, string emailAddress)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        IsDeleted = false;
    }
}