using System.Text.RegularExpressions;

namespace N27_HT1;

public class UserService
{
    private List<User> _users;

    public UserService()
    {
        _users = new List<User>()
        {
            new User("user1@example.com", "P@ssw0rd"),
            new User("john_doe123@gmail.com", "SecurePwd1!"),
            new User("alice.smith99@hotmail.com", "MyP@ss123")
        };
        
        EnsureAdminExists();
    }

    private void EnsureAdminExists()
    {
        bool adminExists = _users.Any(user => user.IsAdmin);
        if (!adminExists)
        {
            _users.First(u => u.IsAdmin = true);
        }
    }

    
    
    public void Add(string email, string password)
    {
        string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        var checkEmail = Regex.IsMatch(email, patternEmail);
        // The password must be at least 8 characters.
        // long and contain at least one uppercase letter,
        // one lowercase letter, one digit, and one special character.
        string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
        var checkPassword = Regex.IsMatch(password, patternPassword);
        
        if (checkEmail && checkPassword)
        {
            _users.Add(new User(email, password));
        }
        else
        {
            Console.WriteLine("EmailAddress or password is incorrect!");
        }
    }

    public List<User> GetUsers()
    {
        return _users;
    }

}