namespace N22_HT2;

internal class ReviewList<TReview> : IReviewList<TReview> where TReview : IReview
{
    private List<TReview> _reviews = new();


    public void Add(TReview item)
    {
        _reviews.Add(item);
    }

    public void GetOverallReview()
    {

        if (!_reviews.Any())
        {
            Console.WriteLine("Be the first leave a review for this product");
            return;
        }
        else if (_reviews.All(review => review.Star == 5))
        {
            Console.WriteLine("Great News! All reviews for this product are 5 star raitings");
            return;
        }

        var review = _reviews.FirstOrDefault(review => review.Star == 1);
        if (review != null)
        {
            Console.WriteLine(review.Message);
        }

    }

    public TReview? GetReview(Guid id)
    {
        foreach (var review in _reviews)
            if (review.Id == id)
                return review;

        return default(TReview);
    }

    public TReview? GetReview(string message)
    {
        foreach (var review in _reviews)
            if (review.Message == message)
                return review;
        return default(TReview);
    }

    public void Remove(Guid id)
    {
        foreach (var review in _reviews)
            if (review.Id == id)
                _reviews.Remove(review);
    }

    public void Remove(TReview item)
    {
        _reviews.Remove(item);
    }

    public void Update(Guid id, int star, string message)
    {
        foreach (var review in _reviews)
            if (review.Id == id)
            {
                review.Star = star;
                review.Message = message;
            }
    }
}