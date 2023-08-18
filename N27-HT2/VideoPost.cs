namespace N27_HT2;

public class VideoPost
{
    public Guid Id { get;}
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public Topics Topic { get; set; }

    public VideoPost(string? title, string? description, int likes, int dislikes, Topics topic)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Likes = likes;
        Dislikes = dislikes;
        Topic = topic;
    }

    public override string ToString()
    {
        return $"{Title} {Description} {Likes} {Dislikes} {Topic}";
    }
}