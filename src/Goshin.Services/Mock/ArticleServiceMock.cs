using Goshin.Domain.Models;
using Goshin.Services.Contracts;

namespace Goshin.Services.Mock;

public class ArticleServiceMock : IArticleService
{
    public Task<Article> GetByIdAsync(Guid id) 
        => Task.FromResult(new Article
        {
            Id = id,
            Title = "Mock Article Title",
            Content = "Mock article content"
        });

    public Task<List<Article>> GetAllAsync() 
        => Task.FromResult(new List<Article>
        {
            new() { Id = Guid.NewGuid(), Title = "Mock Article Title 1", Content = "Mock article content 1" },
            new() { Id = Guid.NewGuid(), Title = "Mock Article Title 2", Content = "Mock article content 2" },
            new() { Id = Guid.NewGuid(), Title = "Mock Article Title 3", Content = "Mock article content 3" },
        });
}