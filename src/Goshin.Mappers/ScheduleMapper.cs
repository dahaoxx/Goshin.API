using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.Mappers;

public static class ScheduleMapper
{
    public static ScheduleResponse ToResponse(this Schedule schedule)
        => new()
        {
            Id = schedule.Id,
            Title = schedule.Title,
            Class = schedule.Class,
            Lecture = schedule.Lecture.Select(l => l.ToResponse()),
        };
}