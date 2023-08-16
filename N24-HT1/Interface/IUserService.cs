using N24_HT1.models;

namespace N24_HT1.Service;

public interface IUserService
{
    List<User> Get(int pageSize, int pageToken)
    {
        throw new InvalidOperationException();
    }
    
    List<User> Search(string searchKeyword, int pageSize, int pageToken)
    {
        throw new InvalidOperationException();
    }
    
    List<User> Filter(UserFilterModel model)
    {
        throw new InvalidOperationException();
    }

    User Add(string firstname, string lastname, string email);

    void Update(User user);

    void Delete(Guid id);

}