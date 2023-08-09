class User
{
    public string FirstName;
    public string MiddleName;
    public string LastName;

    public User(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + FirstName.GetHashCode();
        hash = hash * 23 + MiddleName.GetHashCode();
        hash = hash * 23 + LastName.GetHashCode();
        return hash;
    }

    public override bool Equals(object obj)
    {
        User otherUser = (User)obj;
        return FirstName == otherUser.FirstName &&
               MiddleName == otherUser.MiddleName &&
               LastName == otherUser.LastName;
        return false;
    }
}