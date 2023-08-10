namespace N22_HT2;

public class User
{
    public string? Name { get; set; }
    public string? SurName { get; set; }
    public string? Fname { get; set; }
    
    public string? Email { get; set; }
    public string? UserName { get; set; }
    public bool IsActive { get; set; }

    public User(string name, string surname, string fname, string email, string username)
    {
        Name = name;
        SurName = surname;
        Fname = fname;
        Email = email;
        UserName = username;
        IsActive = false;
    }
}