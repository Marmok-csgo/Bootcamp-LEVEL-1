namespace N23_HT2;

public class User
{
    public string? FirsName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? EmailAdress { get; set; }

    public User(string firsName, string lastName, string emailAdress)
    {
        FirsName = firsName;
        LastName = lastName;
        EmailAdress = emailAdress;
    }
}