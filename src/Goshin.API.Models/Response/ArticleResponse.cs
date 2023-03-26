using Goshin.Domain.Models;

namespace Goshin.API.Models.Response;

public class ArticleResponse // TODO: Replace with real model
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    
    public static ArticleResponse FromDomainModel(Article article)
    {
        return new ArticleResponse
        {
            Id = article.Id,
            Title = article.Title,
            Content = article.Content
        };
    }
}