using Goshin.Domain.Contracts;
using Goshin.Domain.Enums;

namespace Goshin.Domain.Models;

public class Article : IVisibleTo
{
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Content { get; init; } = string.Empty;
    public IEnumerable<Level> VisibleTo { get; init; } = new List<Level>();
}