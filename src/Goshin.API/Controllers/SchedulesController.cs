using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class SchedulesController : AuthControllerBase
{
    [HttpGet("{id:guid}")]
    public ScheduleResponse Get(Guid id)
    {
        return new ScheduleResponse
        {
            Id = id,
            Title = "Hello World",
            Content = "This is a sample article."
        };
    }
}