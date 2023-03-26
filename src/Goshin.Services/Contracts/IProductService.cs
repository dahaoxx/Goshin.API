using Goshin.Domain.Models;

namespace Goshin.Services.Contracts;

public interface IProductService
{
    Task<Product> GetByIdAsync(Guid id);
    Task<IEnumerable<Product>> GetAllAsync();
}