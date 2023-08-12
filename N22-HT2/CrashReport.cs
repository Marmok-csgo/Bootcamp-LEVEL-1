namespace N22_HT2;

internal class CrashReport : IReview
{
    public Guid Id { get; set; }

    public int Star { get; set; }

    public string Message { get; set; }

    public string? screenshot { get; set; }

    public CrashReport(int star, string message, string screenshot) => (Id, Star, Message, screenshot) = (Guid.NewGuid(), star, message, screenshot);

    public override string ToString() => $"Star(s): {Star}, Message: {Message}";

}