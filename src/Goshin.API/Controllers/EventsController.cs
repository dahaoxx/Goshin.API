using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Mappers;
using Goshin.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class EventsController : AuthControllerBase
{
    private readonly IEventService _eventService;

    public EventsController(IEventService eventService)
    {
        _eventService = eventService;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EventResponse>>> Get()
    {
        var events = await _eventService.GetAllAsync();
        var eventResponses = events.Select(e => e.ToResponse());
        return Ok(eventResponses);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<EventResponse>> Get(Guid id)
    {
        var @event = await _eventService.GetByIdAsync(id);
        return Ok(@event.ToResponse());
    }
}