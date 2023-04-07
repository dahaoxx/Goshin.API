using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Domain.Enums;
using Goshin.Mappers;
using Goshin.Services.Sanity.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class EventsController : AuthControllerBase
{
    private readonly ISanityEventService _sanityEventService;

    public EventsController(ISanityEventService sanityEventService)
    {
        _sanityEventService = sanityEventService;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EventResponse>>> Get()
    {
        var events = await _sanityEventService.GetAllAsync();
        var eventList = events.ToList();
        
        if(!eventList.Any())
        {
            return NotFound();
        }
        
        return Ok(eventList.ToResponse());
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<EventResponse>> Get(Guid id)
    {
        var @event = await _sanityEventService.GetByIdAsync(id);
        
        if (@event is null)
        {
            return NotFound();
        }

        // TODO: VisibleTo should be checked against UserSession before returning
        return Ok(@event.ToResponse());
    }

    [HttpGet("{visibleTo}")]
    public async Task<ActionResult<IEnumerable<EventResponse>>> Get(Level visibleTo) // TODO: Level should be retrieved from UserSession
    {
        var events = await _sanityEventService.GetVisibleToAsync(visibleTo);
        var eventList = events.ToList();
        
        if (!eventList.Any())
        {
            return NotFound();
        }

        return Ok(eventList.ToResponse());
    }
}