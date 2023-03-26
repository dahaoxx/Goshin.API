using Goshin.Domain.Models;
using Goshin.Services.Contracts;

namespace Goshin.Services.Mock;

public class EventServiceMock : IEventService
{
    public Task<Event> GetByIdAsync(Guid id) 
        => Task.FromResult(new Event
        {
            Id = id,
            Title = "Mock Event Title",
            Content = "Mock event content"
        });

    public async Task<IEnumerable<Event>> GetAllAsync() 
        => await Task.FromResult(new List<Event>
        {
            new() { Id = Guid.NewGuid(), Title = "Mock Event Title 1", Content = "Mock event content 1" },
            new() { Id = Guid.NewGuid(), Title = "Mock Event Title 2", Content = "Mock event content 2" },
            new() { Id = Guid.NewGuid(), Title = "Mock Event Title 3", Content = "Mock event content 3" },
        });
}