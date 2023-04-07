using Goshin.API.Models.Response;
using Goshin.Domain.Enums;
using Goshin.Domain.Models;

namespace Goshin.Mappers;

public static class EventMapper
{
    public static EventResponse ToResponse(this Event @event, bool isSignedUp, Level userLevel)
        => new()
        {
            Id = @event.Id,
            Title = @event.Title,
            Content = @event.Content,
            Date = @event.Date,
            LastSignupDate = @event.LastSignupDate,
            IsSignedUp = isSignedUp,
            CanParticipate = @event.CanParticipate.Any(x => x == userLevel),
            IsFree = @event.Price <= 0,
            Price = @event.Price
        };
}