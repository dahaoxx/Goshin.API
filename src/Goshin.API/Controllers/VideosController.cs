/*using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Domain.Enums;
using Goshin.Mappers;
using Goshin.Services.Sanity.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class VideosController : AuthControllerBase
{
    private readonly IVideosService _videosService;

    public VideosController(IVideosService videosService)
    {
        _videosService = videosService;
    }

    [HttpGet("{level}:{page:int}:{pageSize:int}")]
    public async Task<ActionResult<IEnumerable<VideoResponse>>> Get(Level level, int page = 1, int pageSize = 10)
    {
        var schedule = await _videosService.GetByClassPaginatedAsync(level, page, pageSize);
        var videResponses = schedule.Select(v => v.ToResponse());
        return Ok(videResponses);
    }
}*/