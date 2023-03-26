using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.Mappers;

public static class ProductMapper
{
    public static ProductResponse ToResponse(this Product product)
    {
        return new ProductResponse
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            ImageUrl = product.ImageUrl,
            Sizes = product.Sizes
        };
    }
}