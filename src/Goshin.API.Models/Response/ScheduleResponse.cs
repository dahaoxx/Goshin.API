using Goshin.Domain.Enums;

namespace Goshin.API.Models.Response;

public class ScheduleResponse // TODO: Replace with real model
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public Level Class { get; set; }
    public IEnumerable<LectureResponse> Lecture { get; set; } = new List<LectureResponse>();
}