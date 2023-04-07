using Goshin.Domain.Enums;
using Goshin.Domain.Models;

namespace Goshin.Services.Sanity.Contracts;

public interface ISanityEventService
{
    Task<IEnumerable<Event>> GetAllAsync();
    Task<Event?> GetByIdAsync(Guid id);
    Task<IEnumerable<Event>> GetVisibleToAsync(Level visibleTo);
}