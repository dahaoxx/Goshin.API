/*using Goshin.Domain.Models;
using Goshin.Services.Sanity.Contracts;
using Goshin.Services.Sanity.Models;

namespace Goshin.Services.Sanity.Mock;

public class EventServiceMock : IEventService
{
    public Task<Event> GetByIdAsync(string id) 
        => Task.FromResult(new SanityEvent
        {
            Id = id,
            Title = "Mock Event Title",
            Content = "Mock event content"
        });

    public async Task<IEnumerable<Event>> GetAllAsync() 
        => await Task.FromResult(new List<SanityEvent>
        {
            new() { Id = "eventId1", Title = "Mock Event Title 1", Content = "Mock event content 1" },
            new() { Id = "eventId2", Title = "Mock Event Title 2", Content = "Mock event content 2" },
            new() { Id = "eventId3", Title = "Mock Event Title 3", Content = "Mock event content 3" },
        });
}*/