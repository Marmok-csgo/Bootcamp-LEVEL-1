using API.Models;

namespace API.Files;

public interface IFileContext
{
    public User AddUser(User user);
}