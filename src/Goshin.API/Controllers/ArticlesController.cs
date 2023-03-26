using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Mappers;
using Goshin.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class ArticlesController : AuthControllerBase
{
    private readonly IArticleService _articleService;

    public ArticlesController(IArticleService articleService)
    {
        _articleService = articleService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ArticleResponse>>> Get()
    {
        var articles = await _articleService.GetAllAsync();
        var articleResponses = articles.Select(a => a.ToResponse());
        return Ok(articleResponses);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ArticleResponse>> Get(Guid id)
    {
        var article = await _articleService.GetByIdAsync(id);
        return Ok(article.ToResponse());
    }
}
