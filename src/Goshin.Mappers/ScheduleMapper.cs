using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.Mappers;

public static class ScheduleMapper
{
    public static ScheduleResponse ToResponse(this Schedule schedule)
    {
        return new ScheduleResponse
        {
            Id = schedule.Id,
            Title = schedule.Title,
            LectureInfo = schedule.LectureInfo.Select(x => new LectureInfoResponse
            {
                Name = x.Name,
                Number = x.Number,
                Description = x.Description,
                Date = x.Date
            })
        };
    }
}