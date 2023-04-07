/*using Goshin.Domain.Models;
using Goshin.Services.Sanity.Contracts;

namespace Goshin.Services.Sanity.Mock;

public class ArticleServiceMock : IArticleService
{
    public Task<Article> GetByIdAsync(string id) 
        => Task.FromResult(new Article
        {
            Id = id,
            Title = "Mock Article Title",
            Content = "Mock article content"
        });

    public async Task<List<Article>> GetAllAsync() 
        => await Task.FromResult(new List<Article>
        {
            new() { Id = "articleId1", Title = "Mock Article Title 1", Content = "Mock article content 1" },
            new() { Id = "articleId2", Title = "Mock Article Title 2", Content = "Mock article content 2" },
            new() { Id = "articleId3", Title = "Mock Article Title 3", Content = "Mock article content 3" },
        });
}*/