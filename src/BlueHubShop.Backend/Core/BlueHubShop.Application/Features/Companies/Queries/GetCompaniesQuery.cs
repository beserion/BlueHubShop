using MediatR;
using Microsoft.EntityFrameworkCore;
using BlueHubShop.Application.Common.Interfaces;
using BlueHubShop.Application.DTOs;

namespace BlueHubShop.Application.Features.Companies.Queries;

public record GetCompaniesQuery(string? Search = null, string? City = null) : IRequest<List<CompanyDto>>;

public class GetCompaniesQueryHandler : IRequestHandler<GetCompaniesQuery, List<CompanyDto>>
{
    private readonly IApplicationDbContext _context;

    public GetCompaniesQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<CompanyDto>> Handle(GetCompaniesQuery request, CancellationToken cancellationToken)
    {
        var query = _context.GnlCompanies
            .AsNoTracking()
            .Where(c => c.Active != false);

        if (!string.IsNullOrWhiteSpace(request.Search))
        {
            var search = request.Search.Trim().ToLower();
            query = query.Where(c => 
                (c.CompanyName != null && c.CompanyName.ToLower().Contains(search)) ||
                (c.Description != null && c.Description.ToLower().Contains(search)) ||
                (c.CompanyType != null && c.CompanyType.ToLower().Contains(search))
            );
        }

        if (!string.IsNullOrWhiteSpace(request.City))
        {
            query = query.Where(c => c.City != null && c.City.ToLower().Contains(request.City.ToLower()));
        }

        return await query
            .OrderBy(c => c.CompanyName)
            .Take(50)
            .Select(c => new CompanyDto
            {
                Id = c.Id,
                Name = c.CompanyName ?? c.ShortName ?? "Marine Supplier",
                CompanyType = c.CompanyType ?? "Ship Chandler & Technical Supplier",
                City = c.City ?? "Tuzla",
                Country = c.Country ?? "Turkey",
                EmailAddress = c.EmailAddress,
                OfficePhone = c.OfficePhone,
                WebAddress = c.WebAddress,
                Description = c.Description ?? "Certified global ship chandler and technical marine equipment supplier.",
                IsVerified = true,
                Rating = 4.8m,
                ActiveProductsCount = _context.GnlProducts.Count(p => p.CompanyId == c.Id && p.IsDeleted != true),
                Certifications = new List<string> { "ISO 9001", "ISSA Member", "IMPA Quality" },
                MainPorts = new List<string> { c.City ?? "Tuzla", "Istanbul", "Yalova", "Rotterdam" },
                Languages = new List<string> { "Turkish", "English", "Russian" }
            })
            .ToListAsync(cancellationToken);
    }
}
