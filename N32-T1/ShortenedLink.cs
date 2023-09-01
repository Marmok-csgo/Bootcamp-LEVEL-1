namespace N32_T1;

public class ShortenedLink
{
    public int Id { get; set; }
    public string? OriginalUrl { get; set; }
    public string? ShortenedUrl { get; set; }


    public ShortenedLink(int id, string? originalUrl, string? shortenedUrl)
    {
        Id = id;
        OriginalUrl = originalUrl;
        ShortenedUrl = shortenedUrl;
    }


    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Id.GetHashCode();
            hash = hash * 23 + (OriginalUrl?.GetHashCode() ?? 0);
            hash = hash * 23 + (ShortenedUrl?.GetHashCode() ?? 0);
            return hash;
        }
    }

    public override bool Equals(object? obj)
    {
        ShortenedLink other = (ShortenedLink)obj;
        return Id == other.Id &&
               OriginalUrl == other.OriginalUrl &&
               ShortenedUrl == other.ShortenedUrl;
    }

}