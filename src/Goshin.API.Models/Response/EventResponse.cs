namespace Goshin.API.Models.Response;

public class EventResponse
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime Date { get; init; }
    public DateTime LastSignupDate { get; init; }
    public bool CanParticipate { get; init; }
    public bool IsSignedUp { get; init; }
    public bool IsFree { get; set; }
    public int Price { get; init; }
}