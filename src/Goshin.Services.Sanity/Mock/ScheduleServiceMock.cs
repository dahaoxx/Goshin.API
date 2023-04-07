/*using Goshin.Domain.Enums;
using Goshin.Domain.Models;
using Goshin.Services.Sanity.Contracts;

namespace Goshin.Services.Sanity.Mock;

public class ScheduleServiceMock : IScheduleService
{
    public Task<Schedule> GetByClassAsync(Level level)
    {
        return Task.FromResult(new Schedule
        {
            Id = Guid.NewGuid(),
            Title = "Mock Schedule Title",
            Class = level,
            Lecture = new List<Lecture>
            {
                new() { Name = "Lecture 1", Date = DateTimeOffset.Now.AddDays(10), Description = "Lecture 1 description", Number = "1", Videos = new List<Video> { new() { Title = "Video 1", Url = "test.com/video/1", ThumbnailUrl = "test.com/thumbnail/1"} } },
                new() { Name = "Lecture 2", Date = DateTimeOffset.Now.AddDays(20), Description = "Lecture 2 description", Number = "2", Videos = new List<Video> { new() { Title = "Video 2", Url = "test.com/video/2", ThumbnailUrl = "test.com/thumbnail/2"} } },
                new() { Name = "Lecture 3", Date = DateTimeOffset.Now.AddDays(30), Description = "Lecture 3 description", Number = "3", Videos = new List<Video> { new() { Title = "Video 3", Url = "test.com/video/3", ThumbnailUrl = "test.com/thumbnail/3"} } },
                new() { Name = "Lecture 4", Date = DateTimeOffset.Now.AddDays(40), Description = "Lecture 4 description", Number = "4", Videos = new List<Video> { new() { Title = "Video 4", Url = "test.com/video/4", ThumbnailUrl = "test.com/thumbnail/4"} } },
                new() { Name = "Lecture 5", Date = DateTimeOffset.Now.AddDays(50), Description = "Lecture 5 description", Number = "5", Videos = new List<Video> { new() { Title = "Video 5", Url = "test.com/video/5", ThumbnailUrl = "test.com/thumbnail/5"} } },
            }
        });
    }
}*/