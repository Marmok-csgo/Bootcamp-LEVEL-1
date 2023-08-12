namespace N22_HT2;

internal interface IReview
{
    Guid Id { get; set; }
    int Star { get; set; }
    string Message { get; set; }
}