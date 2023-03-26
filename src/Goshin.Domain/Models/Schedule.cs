using Goshin.Domain.Enums;

namespace Goshin.Domain.Models;

public class Schedule
{
    public Guid Id { get; set; }
    public Level Class { get; set; }
    public string Title { get; set; } = string.Empty;
    public IEnumerable<Lecture> Lecture = new List<Lecture>();
}