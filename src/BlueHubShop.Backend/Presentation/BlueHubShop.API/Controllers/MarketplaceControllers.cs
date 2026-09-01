using MediatR;
using Microsoft.AspNetCore.Mvc;
using BlueHubShop.Application.DTOs;
using BlueHubShop.Application.Features.Categories.Queries;
using BlueHubShop.Application.Features.Companies.Queries;
using BlueHubShop.Application.Features.ImpaCodes.Queries;
using BlueHubShop.Application.Features.Rfqs.Commands;

namespace BlueHubShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CategoriesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryDto>>> GetCategories()
    {
        var result = await _mediator.Send(new GetCategoriesQuery());
        return Ok(result);
    }
}

[ApiController]
[Route("api/[controller]")]
public class CompaniesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CompaniesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<CompanyDto>>> GetCompanies([FromQuery] string? search, [FromQuery] string? city)
    {
        var result = await _mediator.Send(new GetCompaniesQuery(search, city));
        return Ok(result);
    }
}

[ApiController]
[Route("api/[controller]")]
public class ImpaCodesController : ControllerBase
{
    private readonly IMediator _mediator;

    public ImpaCodesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<ImpaGroupDto>>> GetImpaCodes([FromQuery] string? search)
    {
        var result = await _mediator.Send(new GetImpaCodesQuery(search));
        return Ok(result);
    }
}

[ApiController]
[Route("api/[controller]")]
public class RfqController : ControllerBase
{
    private readonly IMediator _mediator;

    public RfqController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateRfq([FromBody] CreateRfqRequestDto request)
    {
        var id = await _mediator.Send(new CreateRfqCommand(request));
        return Ok(new { rfqId = id, success = true, message = "RFQ submitted successfully" });
    }
}
