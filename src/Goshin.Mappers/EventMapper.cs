﻿using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.Mappers;

public static class EventMapper
{
    public static EventResponse ToResponse(this Event @event)
    {
        return new EventResponse
        {
            Id = @event.Id,
            Title = @event.Title,
            Content = @event.Content
        };
    }
}