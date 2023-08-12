namespace N22_HT2;

class Program
{
    static void Main()
    {
        var reviewList = new ReviewList<IReview>();
        reviewList.GetOverallReview();

        var review1 = new Review(4, "1-review message");
        var review2 = new Review(2, "2-review message");
        var crash1 = new CrashReport(3, "1-crash report message", "screenshot/path.png");
        var crash2 = new CrashReport(5, "2-crash report message", "screenshot/path2.png");

        reviewList.Add(review1);
        reviewList.Add(review2);
        reviewList.Add(crash1);
        reviewList.Add(crash2);

        reviewList.GetOverallReview();
        Console.WriteLine(review1);

        var review = reviewList.GetReview(review1.Id);
        Console.WriteLine(reviewList.GetReview(review2.Message));


        reviewList.Update(crash1.Id, 1, "O'zgartirilgan message");
        Console.WriteLine(crash1);
    }
}