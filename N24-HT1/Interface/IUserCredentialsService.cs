using N24_HT1.models;

namespace N24_HT1.Service;

public interface IUserCredentialsService
{
    UserCredentials Add(Guid userId, string password);
    UserCredentials GetByUserId(Guid userId);
}