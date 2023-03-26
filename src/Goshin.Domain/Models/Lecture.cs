namespace Goshin.Domain.Models;

public class Lecture
{
    public string Name { get; set; } = string.Empty;
    public DateTimeOffset Date { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IEnumerable<Video> Videos { get; set; } = new List<Video>();
}