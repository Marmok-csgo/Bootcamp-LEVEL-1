using System.Text.RegularExpressions;
using N24_HT1.Service;

namespace N24_HT1.models;

public class UserCredentialService : IUserCredentialsService
{
    private List<UserCredentials> _userCredentials = new List<UserCredentials>();
    public UserCredentials Add(Guid userId, string password)
    {
        if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"))
        {
            var userCradential = new UserCredentials(password, userId);
            _userCredentials.Add(userCradential);
            return userCradential;

        }
        else
        {
            throw new InvalidOperationException("User credentials Invalid");
        }
    }

    public UserCredentials GetByUserId(Guid userId)
    {
        return (_userCredentials.Any(c => c.UserId == userId)
            ? _userCredentials.Find(c => c.UserId == userId)
            : null) ?? throw new InvalidOperationException();
    }
}