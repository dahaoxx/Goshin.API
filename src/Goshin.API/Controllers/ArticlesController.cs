using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class ArticlesController : AuthControllerBase
{
    [HttpGet("{id:guid}")]
    public ArticleResponse Get(Guid id)
    {
        return new ArticleResponse
        {
            Id = id,
            Title = "Hello World",
            Content = "This is a sample article."
        };
    }
}
