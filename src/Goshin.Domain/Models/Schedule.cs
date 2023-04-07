
namespace Goshin.Domain.Models;

public class Schedule
{
    public Guid Id { get; set; }
    public Enums.Level Class { get; set; }
    public string Title { get; set; } = string.Empty;
    public IEnumerable<Lecture> Lecture = new List<Lecture>();
}