using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.API.Mappers;

public static class LectureMapper
{
    public static LectureResponse ToResponse(this Lecture lecture)
        => new()
        {
            Name = lecture.Name,
            Date = lecture.Date,
            Number = lecture.Number,
            Description = lecture.Description,
            Videos = lecture.Videos.Select(v => v.ToResponse()),
        };
}