using Goshin.Domain.Enums;
using Goshin.Domain.Models;

namespace Goshin.Services.Sanity.Contracts;

public interface ISanityArticleService
{
    Task<IEnumerable<Article>> GetAllAsync();
    Task<Article?> GetByIdAsync(Guid id);
    Task<IEnumerable<Article>> GetVisibleToAsync(Level visibleTo);
}