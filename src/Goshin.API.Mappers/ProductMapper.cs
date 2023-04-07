using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.API.Mappers;

public static class ProductMapper
{
    public static ProductResponse ToResponse(this Product product)
        => new()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            ImageUrl = product.ImageUrl,
            Sizes = product.Sizes
        };
}