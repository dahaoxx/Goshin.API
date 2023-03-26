using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class EventsController : AuthControllerBase
{
    [HttpGet("{id:guid}")]
    public EventResponse Get(Guid id)
    {
        return new EventResponse()
        {
            Id = id,
            Title = "Hello World",
            Content = "This is a sample article."
        };
    }
}