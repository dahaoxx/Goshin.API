using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Domain.Enums;
using Goshin.Mappers;
using Goshin.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class SchedulesController : AuthControllerBase
{
    private readonly IScheduleService _scheduleService;

    public SchedulesController(IScheduleService scheduleService)
    {
        _scheduleService = scheduleService;
    }

    [HttpGet("{class}")]
    public async Task<ActionResult<ScheduleResponse>> Get(ScheduleClass @class)
    {
        var schedule = await _scheduleService.GetByClassAsync(@class);
        return schedule.ToResponse();
    }
}