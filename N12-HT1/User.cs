public class User
{
    private string firstName;
    private string lastName;
    private string patronymic;

    public User(string fullName)
    {
        var nameParts = fullName.Split(' ');
        if (nameParts.Length >= 1)
            firstName = nameParts[0];
        if (nameParts.Length >= 2)
            lastName = nameParts[1];
        if (nameParts.Length >= 3)
            patronymic = nameParts[2];
    }

    public string FullName
    {
        get { return $"{FirstName} {LastName} {Patronymic}"; }
        set
        {
            var nameParts = value.Split(' ');
            if (nameParts.Length >= 1)
                firstName = nameParts[0];
            if (nameParts.Length >= 2)
                lastName = nameParts[1];
            if (nameParts.Length >= 3)
                patronymic = nameParts[2];
        }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Patronymic
    {
        get { return patronymic; }
        set { patronymic = value; }
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName, Patronymic);
    }

    public override bool Equals(object obj)
    {
        if (obj is User user)
        {
            return FirstName == user.FirstName &&
                   LastName == user.LastName &&
                   Patronymic == user.Patronymic;
        }
        return false;
    }
}