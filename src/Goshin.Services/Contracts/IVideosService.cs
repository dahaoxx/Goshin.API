using Goshin.Domain.Enums;
using Goshin.Domain.Models;

namespace Goshin.Services.Contracts;

public interface IVideosService
{
    Task<IEnumerable<Video>> GetByClassPaginatedAsync(Level level, int page, int pageSize);
}