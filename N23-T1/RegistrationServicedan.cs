namespace N23_T1;

public class RegistrationServicedan
{
    private List<User> _users = new List<User>();


    public void Register(string emailadress, int pass)
    {
        if(_users.Any(user => user.EmailAdress == emailadress))
            Console.WriteLine("Already Exsist!");
        else
        {
            _users.Add(new User(emailadress, pass));
        }
    }
}