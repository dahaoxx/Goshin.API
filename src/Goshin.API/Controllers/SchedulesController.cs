/*using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Domain.Enums;
using Goshin.API.Mappers;
using Goshin.Services.Sanity.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class SchedulesController : AuthControllerBase
{
    private readonly IScheduleService _scheduleService;

    public SchedulesController(IScheduleService scheduleService)
    {
        _scheduleService = scheduleService;
    }

    [HttpGet("{level}")]
    public async Task<ActionResult<ScheduleResponse>> Get(Level level)
    {
        var schedule = await _scheduleService.GetByClassAsync(level);
        return schedule.ToResponse();
    }
}*/