using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Response;
using Goshin.Mappers;
using Goshin.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class ProductsController : AuthControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    
    [HttpGet] 
    public async Task<ActionResult<IEnumerable<ProductResponse>>> Get()
    {
        var products = await _productService.GetAllAsync();
        var productResponses = products.Select(p => p.ToResponse());
        return Ok(productResponses);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ProductResponse>> Get(Guid id)
    {
        var product = await _productService.GetByIdAsync(id);
        return Ok(product.ToResponse());
    }
}