namespace N23_T1;

public class User
{
    public string? EmailAdress { get; set; }
    public int Password { get; set; }


    public User(string email, int pass)
    {
        EmailAdress = email;
        Password = pass;
    }
}