using System.Text.Json;

namespace N27_HT2;

class Program
{
    static void Main()
    {
        var videoPosts = new List<VideoPost>
        {
            new VideoPost("Funny Cat Compilation", "Watch these hilarious cats in action!", 2_654, 541, Topics.Fun),
            new VideoPost("Advanced Web Development Techniques", "Learn the latest web development tricks.", 1_000, 310, Topics.IT),
            new VideoPost("Epic Gaming Moments", "Witness incredible gaming highlights.", 53_999, 1_119, Topics.Gaming),
            new VideoPost("How to Tell Jokes Like a Pro", "Master the art of delivering jokes.", 5_409, 1_573, Topics.Fun),
            new VideoPost("Speedrun: The Legend of Zara", "Watch the fastest playthrough of this classic game.", 30_613, 887, Topics.Gaming),
            new VideoPost("Investing in Stocks 101", "Learn the basics of stock market investment.", 7_711, 361, Topics.Business),
            new VideoPost("Stand-up Comedy Showcase", "Laugh out loud with these hilarious comedians.", 3_514, 2_777, Topics.Fun),
            new VideoPost("Creating User-Friendly UI/UX", "Design interfaces that users will love.", 8_981, 576, Topics.IT),
            new VideoPost("Cybersecurity Essentials", "Protect your online presence with these tips.", 12_750, 411, Topics.IT),
            new VideoPost("Entrepreneurial Success Stories", "Discover the secrets behind successful businesses.", 8_891, 201, Topics.Business)
            
        };
        
        Console.WriteLine($"Most Earn Likes: {videoPosts.MaxBy(x => x.Likes)}\n");
        
        Console.WriteLine($"Min Earn Dislike: {videoPosts.MinBy(x => x.Dislikes)}\n");
        
        Console.WriteLine($"Average Earn Likes: {videoPosts.Average(x => x.Likes)}\n");
        
        Console.WriteLine($"All movies sum of Dislikes: {videoPosts.Sum(x => x.Dislikes)}\n");
        
        Console.WriteLine($"Movies Which Title and Description: ");
        var videosWithOnlyTitleAndDescription = videoPosts.Select(video => new { video.Title, video.Description }).ToList();
        videosWithOnlyTitleAndDescription.ForEach(video => Console.WriteLine($"Title: {video.Title} | Description : {video.Description}"));
        
        Console.WriteLine("making videos unique by topic:");
        var topics = videoPosts.DistinctBy(x => x.Topic).ToList();
        topics.ForEach(Console.WriteLine);
        Console.WriteLine();
        
        var grouped = videoPosts.GroupBy(
            video => video.Topic,
            (topic, videos) => new
            {
                Topic = topic,
                Videos = videos.ToList()
            }
        );
        
        Console.WriteLine(JsonSerializer.Serialize(grouped));
    }
}