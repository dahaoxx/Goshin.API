using Goshin.Domain.Models;
using Goshin.Services.Contracts;

namespace Goshin.Services.Mock;

public class ProductServiceMock : IProductService
{
    public Task<Product> GetByIdAsync(Guid id) 
        => Task.FromResult(new Product
        {
            Id = id,
            Name = "Mock Product Name",
            Description = "Mock product description",
            Price = 100,
            ImageUrl = "https://via.placeholder.com/150",
            Sizes = new List<string> { "S", "M", "L" }
        });

    public async Task<IEnumerable<Product>> GetAllAsync() 
        => await Task.FromResult(new List<Product>
        {
            new() { Id = Guid.NewGuid(), Name = "Mock Product Name 1", Description = "Mock product description 1", Price = 100, ImageUrl = "https://via.placeholder.com/150", Sizes = new List<string> { "S", "M", "L" } },
            new() { Id = Guid.NewGuid(), Name = "Mock Product Name 2", Description = "Mock product description 2", Price = 200, ImageUrl = "https://via.placeholder.com/150", Sizes = new List<string> { "S", "M", "L" } },
            new() { Id = Guid.NewGuid(), Name = "Mock Product Name 3", Description = "Mock product description 3", Price = 300, ImageUrl = "https://via.placeholder.com/150", Sizes = new List<string> { "S", "M", "L" } },
            new() { Id = Guid.NewGuid(), Name = "Mock Product Name 4", Description = "Mock product description 4", Price = 400, ImageUrl = "https://via.placeholder.com/150", Sizes = new List<string> { "S", "M", "L" } },
            new() { Id = Guid.NewGuid(), Name = "Mock Product Name 5", Description = "Mock product description 5", Price = 500, ImageUrl = "https://via.placeholder.com/150", Sizes = new List<string> { "S", "M", "L" } },
        });
}