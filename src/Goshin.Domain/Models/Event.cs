using Goshin.Domain.Contracts;
using Goshin.Domain.Enums;

namespace Goshin.Domain.Models;

public class Event : IVisibleTo
{
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Content { get; init; } = string.Empty;
    public DateTime Date { get; init; }
    public DateTime LastSignupDate { get; init; }
    public IEnumerable<Level> VisibleTo { get; init; } = new List<Level>();
    public IEnumerable<Level> CanParticipate { get; init; } = new List<Level>();
    public int Price { get; init; }
}