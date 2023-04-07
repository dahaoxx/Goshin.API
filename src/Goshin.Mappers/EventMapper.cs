using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.Mappers;

public static class EventMapper
{
    public static IEnumerable<EventResponse> ToResponse(this IEnumerable<Event> events)
        => events.Select(ToResponse);
    
    public static EventResponse ToResponse(this Event @event)
        => new()
        {
            Id = @event.Id,
            Title = @event.Title,
            Content = @event.Content,
            Date = @event.Date,
            LastSignupDate = @event.LastSignupDate,
            IsFree = @event.Price <= 0,
            Price = @event.Price
        };
}