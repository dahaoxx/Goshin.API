using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Domain.Enums;
using Goshin.Domain.Models;
using Goshin.API.Mappers;
using Goshin.Services.Contracts;
using Goshin.Services.Sanity.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class EventsController : AuthControllerBase
{
    private readonly ISanityEventService _sanityEventService;
    private readonly IEventService _eventService;

    public EventsController(ISanityEventService sanityEventService, IEventService eventService)
    {
        _sanityEventService = sanityEventService;
        _eventService = eventService;
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

        var eventResponses = await GetResponseList(eventList, Guid.NewGuid(), Level.Basics); // TODO: UserId and Level should be retrieved from UserSession

        return Ok(eventResponses);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<EventResponse>> Get(Guid id)
    {
        var @event = await _sanityEventService.GetByIdAsync(id);
        
        if (@event is null)
        {
            return NotFound();
        }
        
        var isSignedUp = await _eventService.IsSignedUp(Guid.NewGuid(),@event.Id); // TODO: UserId should be retrieved from UserSession

        // TODO: VisibleTo should be checked against UserSession before returning
        return Ok(@event.ToResponse(isSignedUp, Level.Basics));// TODO: Level should be retrieved from UserSession
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

        var eventResponses = await GetResponseList(eventList, Guid.NewGuid(), visibleTo); // TODO: UserId and Level should be retrieved from UserSession

        return Ok(eventResponses);
    }

    private async Task<List<EventResponse>> GetResponseList(List<Event> eventList, Guid userId, Level userLevel)
    {
        var eventResponses = new List<EventResponse>();
        foreach (var @event in eventList)
        {
            var isSignedUp = await _eventService.IsSignedUp(userId, @event.Id);
            eventResponses.Add(@event.ToResponse(isSignedUp, userLevel));
        }

        return eventResponses;
    }
}