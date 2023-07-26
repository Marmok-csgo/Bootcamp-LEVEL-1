using System.Text.RegularExpressions;

public class Email
{
    private string _to;
    private string _from;
    private string _subject;
    private string _content;



    public string To
    {
        get { return _to; }

        set
        {
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var reGex = new Regex(pattern);
            if (reGex.IsMatch(value))
                _to = value;
            else
                throw new FormatException("To Email invalid!");
        }
    }


    public string From
    {
        get
        {
            return _from;
        }
        set
        {
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var regEx = new Regex(pattern);
            if (regEx.IsMatch(value))
                _from = value;
            else
                throw new FormatException("From email invalid!");
        }
    }

    public string Subject
    {
        get
        {
            return _subject;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormatException("Subject must not empty!");

            if (value.Length < 5)
                throw new FormatException("Subject must be at least 5 letters long!");

            _subject = value;
        }
    }

    public string Content
    {
        get
        {
            return _content;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormatException("Content must not empty!");

            if (value.Length < 5)
                throw new FormatException("Content kamida 5 harfdan iborat bo'lishi kerak!");

            _content = value;
        }
    }

    public override string ToString()
    {
        return $"To: {_to}\nFrom: {_from}\nSubject: {_subject}\nContent: {_content}";
    }
}
