using Goshin.Domain.Models;

namespace Goshin.Services.Contracts;

public interface IArticleService
{
    Task<Article> GetByIdAsync(Guid id);
    Task<IEnumerable<Article>> GetAllAsync();
}