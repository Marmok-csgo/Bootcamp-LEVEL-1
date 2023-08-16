using N24_HT1.Service;

namespace N24_HT1.models;

public class RegistrationService
{
    private readonly IUserService _userService;
    private readonly IUserCredentialsService _credentialsService;

    public RegistrationService(IUserService userService, IUserCredentialsService credentialsService)
    {
        _userService = userService;
        _credentialsService = credentialsService;
    }

    public bool Register(string firstName, string lastName, string emailAddress, string password)
    {
        try
        {
            var user = _userService.Add(firstName, lastName, emailAddress);
            _credentialsService.Add(user.Id, password);
            return true;
        }
        catch
        {
            return false;
        }
    }
}