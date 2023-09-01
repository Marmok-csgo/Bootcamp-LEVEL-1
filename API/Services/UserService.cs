using API.Files;
using API.Models;

namespace API.Services;

public class UserService : IUserService
{
    private IFileContext FileContext;

    public UserService(IFileContext fileContext)
    {
        FileContext = fileContext;
    }


    public User AddUser(User user)
    {
        return FileContext.AddUser(user);
    }
}