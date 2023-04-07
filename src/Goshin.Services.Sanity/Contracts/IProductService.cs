using Goshin.Domain.Models;

namespace Goshin.Services.Sanity.Contracts;

public interface IProductService
{
    Task<Product> GetByIdAsync(string id);
    Task<IEnumerable<Product>> GetAllAsync();
}