namespace N23_T2;

public class Book
{
    public string? Name { get; set; }
    
    public int Rating { get; set; }
    
    public string? Author { get; set; }



    public Book(string name, int rating, string author)
    {
        Name = name;
        Author = author;
        Rating = rating <= 10 && rating >= 1 ? rating : throw new Exception("Rating should be from 1 to 10.");
    }
}