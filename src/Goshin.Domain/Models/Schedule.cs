using Goshin.Domain.Enums;

namespace Goshin.Domain.Models;

public class Schedule
{
    public Guid Id { get; set; }
    public ScheduleClass Class { get; set; }
    public string Title { get; set; } = string.Empty;
    public IEnumerable<LectureInfo> LectureInfo = new List<LectureInfo>();
}