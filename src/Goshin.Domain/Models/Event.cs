namespace Goshin.Domain.Models;

public class Event // TODO: Replace with real model
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}