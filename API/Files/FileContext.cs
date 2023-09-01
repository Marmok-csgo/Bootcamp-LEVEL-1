using System.Text.Json;
using API.Models;

namespace API.Files;

public class FileContext : IFileContext
{
    private const string FilePath = @"D:\project\Temp\User.txt";
    private readonly List<User> _users = new List<User>();
    public User AddUser(User user)
    {
        _users.Add(user);

        var jsonData = JsonSerializer.Serialize(_users);
        File.WriteAllText(FilePath, jsonData);
        return user;
    }
}