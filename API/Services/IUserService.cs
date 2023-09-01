using API.Models;

namespace API.Services;

public interface IUserService
{
    User AddUser(User user);
}