using System.Text.RegularExpressions;

namespace N32_T5;

internal class CustomValidator
{
    public static string? IsValidEmailAddress(string? emailAddress, Regex regex)
    {
        if (string.IsNullOrWhiteSpace(emailAddress))
            return "Email address is required.";

        if (emailAddress.Length < 5 && !regex.IsMatch(emailAddress))
            return "Minimum length is 5";

        return null;
    }
}