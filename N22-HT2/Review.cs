namespace N22_HT2;

internal class Review : IReview
{
    public Guid Id { get; set; }

    public int Star { get; set; }

    public string Message { get; set; }


    public Review(int star, string message) => (Id, Star, Message) = (Guid.NewGuid(), star, message);

    public override string ToString() => $"Star(s): {Star}, Message: {Message}";
}