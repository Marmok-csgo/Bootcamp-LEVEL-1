using N24_HT1.Service;

namespace N24_HT1.models;

public class UserService : IUserService
{
    private List<User> _users = new List<User>();
    
    
    public User Add(string firstname, string lastname, string emailaddress)
    {
        if(!_users.Any(user => user.EmailAddress.Equals(firstname, StringComparison.OrdinalIgnoreCase)))
        {
            var newUser = new User(firstname, lastname, emailaddress);
            _users.Add(newUser);
            return newUser;
        }
        else
        {
            throw new InvalidOperationException("This user already exists");
        }

    }
    
    
    public List<User> Get(int pageSize, int pageToken)
    {
        return _users.Where(user => user.IsDeleted)
            .Skip((pageToken - 1) * pageSize ).Take(pageSize).ToList();
    }

    public List<User> Search(string searchKeyword, int pageSize, int pageToken)
    {
        return _users.Where(
                user => !user.IsDeleted &&
                        user.EmailAddress.ToLower().Equals(searchKeyword.ToLower())||
                        user.FirstName.ToLower().Equals(searchKeyword.ToLower())||
                        user.LastName.ToLower().Equals(searchKeyword.ToLower()) )
            .Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
    }

    public List<User> Filter(UserFilterModel model)
    {
        return _users.Where(
                user => !user.IsDeleted &&
                        (model.FirstName == null || user.FirstName.Equals(model.FirstName)) &&
                        (model.LastName  == null ||user.LastName.Equals(model.LastName)))
            .ToList();
    }


    public void Update(User user)
    {
        var temp = _users.Find(u => u.Id == user.Id);
        temp.FirstName = user.FirstName;
        temp.LastName = user.LastName;
        temp.EmailAddress = user.EmailAddress;

    }

    public void Delete(Guid id)
    {
        if (_users.Any(user => user.Id == id))
        {
            var temp = _users.Find(user => user.Id == id);
            temp.IsDeleted = true;
            
        }
        else
        {
            throw new AggregateException("Argument Not Found!");
        }
    }
}