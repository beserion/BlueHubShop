using MediatR;
using Microsoft.AspNetCore.Mvc;
using BlueHubShop.Application.DTOs;
using BlueHubShop.Application.Features.Products.Queries;

namespace BlueHubShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<ProductDto>>> GetProducts(
        [FromQuery] string? search = null,
        [FromQuery] int? categoryId = null,
        [FromQuery] string? impaCode = null,
        [FromQuery] string? port = null,
        [FromQuery] string? condition = null,
        [FromQuery] bool? verifiedOnly = null,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 24)
    {
        int safePage = Math.Max(1, pageNumber);
        int safeSize = pageSize > 0 ? Math.Min(pageSize, 100) : 24;

        var result = await _mediator.Send(new GetProductsQuery(
            search, categoryId, impaCode, port, condition, verifiedOnly, safePage, safeSize));
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto>> GetProductById(int id)
    {
        if (id <= 0) return BadRequest("Invalid product ID.");
        var result = await _mediator.Send(new GetProductByIdQuery(id));
        if (result == null) return NotFound();
        return Ok(result);
    }
}
