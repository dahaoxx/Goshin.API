using Goshin.Domain.Enums;
using Goshin.Domain.Models;
using Goshin.Services.Contracts;

namespace Goshin.Services.Mock;

public class ScheduleServiceMock : IScheduleService
{
    public Task<Schedule> GetByClassAsync(ScheduleClass scheduleClass)
    {
        return Task.FromResult(new Schedule()
        {
            Id = Guid.NewGuid(),
            Title = "Mock Schedule Title",
            Class = scheduleClass,
            LectureInfo = new List<LectureInfo>
            {
                new() { Name = "Lecture 1", Date = DateTimeOffset.Now.AddDays(10), Description = "Lecture 1 description", Number = "1" },
                new() { Name = "Lecture 2", Date = DateTimeOffset.Now.AddDays(20), Description = "Lecture 2 description", Number = "2" },
                new() { Name = "Lecture 3", Date = DateTimeOffset.Now.AddDays(30), Description = "Lecture 3 description", Number = "3" },
                new() { Name = "Lecture 4", Date = DateTimeOffset.Now.AddDays(40), Description = "Lecture 4 description", Number = "4" },
                new() { Name = "Lecture 5", Date = DateTimeOffset.Now.AddDays(50), Description = "Lecture 5 description", Number = "5" },
            }
        });
    }
}