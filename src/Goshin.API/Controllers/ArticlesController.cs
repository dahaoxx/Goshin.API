using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Domain.Enums;
using Goshin.Mappers;
using Goshin.Services.Sanity.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class ArticlesController : AuthControllerBase
{
    private readonly ISanityArticleService _sanityArticleService;

    public ArticlesController(ISanityArticleService sanityArticleService)
    {
        _sanityArticleService = sanityArticleService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ArticleResponse>>> Get()
    {
        var articles = await _sanityArticleService.GetAllAsync();
        var articleList = articles.ToList();
        
        if (!articleList.Any())
        {
            return NotFound();
        }

        return Ok(articleList.ToResponse());
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ArticleResponse>> Get(Guid id)
    {
        var article = await _sanityArticleService.GetByIdAsync(id);
        
        if (article is null)
        {
            return NotFound();
        }

        // TODO: VisibleTo should be checked against UserSession before returning
        return Ok(article.ToResponse());
    }

    [HttpGet("{visibleTo}")]
    public async Task<ActionResult<ArticleResponse>> Get(Level visibleTo) // TODO: Level should be retrieved from UserSession
    {
        var articles = await _sanityArticleService.GetVisibleToAsync(visibleTo);
        var articleList = articles.ToList();
        
        if (!articleList.Any())
        {
            return NotFound();
        }

        return Ok(articleList.ToResponse());
    }
}
