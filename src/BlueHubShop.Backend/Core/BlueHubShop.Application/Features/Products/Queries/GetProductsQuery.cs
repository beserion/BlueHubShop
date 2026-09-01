using MediatR;
using Microsoft.EntityFrameworkCore;
using BlueHubShop.Application.Common.Interfaces;
using BlueHubShop.Application.DTOs;

namespace BlueHubShop.Application.Features.Products.Queries;

public record GetProductsQuery(
    string? Search = null,
    int? CategoryId = null,
    string? ImpaCode = null,
    string? Port = null,
    string? Condition = null,
    bool? VerifiedOnly = null,
    int PageNumber = 1,
    int PageSize = 24
) : IRequest<PagedResult<ProductDto>>;

public class PagedResult<T>
{
    public List<T> Items { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / Math.Max(1, PageSize));
}

public class CompanyBasicInfo
{
    public string? CompanyName { get; set; }
    public string? ShortName { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public bool? Active { get; set; }
}

public class PriceBasicInfo
{
    public int StockId { get; set; }
    public int Id { get; set; }
    public decimal Price { get; set; }
    public string? Currency { get; set; }
}

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, PagedResult<ProductDto>>
{
    private readonly IApplicationDbContext _context;

    public GetProductsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<PagedResult<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        int pageNumber = Math.Max(1, request.PageNumber);
        int pageSize = request.PageSize > 0 ? Math.Min(request.PageSize, 100) : 24;

        var query = _context.GnlProducts
            .AsNoTracking()
            .Where(p => p.IsDeleted != true && p.Active != false);

        // Search text
        if (!string.IsNullOrWhiteSpace(request.Search))
        {
            var search = request.Search.Trim().ToLower();
            query = query.Where(p => 
                (p.ProductName != null && p.ProductName.ToLower().Contains(search)) ||
                (p.ProductNameTr != null && p.ProductNameTr.ToLower().Contains(search)) ||
                (p.ProductCode != null && p.ProductCode.ToLower().Contains(search)) ||
                (p.Impacode != null && p.Impacode.Contains(search)) ||
                (p.PartNo != null && p.PartNo.ToLower().Contains(search)) ||
                (p.Brand != null && p.Brand.ToLower().Contains(search)) ||
                (p.Category != null && p.Category.ToLower().Contains(search))
            );
        }

        // Category filter
        if (request.CategoryId.HasValue)
        {
            query = query.Where(p => p.CategoryId == request.CategoryId || p.ProductCategoryId == request.CategoryId);
        }

        // IMPA Code filter
        if (!string.IsNullOrWhiteSpace(request.ImpaCode))
        {
            query = query.Where(p => p.Impacode != null && p.Impacode.StartsWith(request.ImpaCode));
        }

        // 1. Direct SQL Server Count
        var totalCount = await query.CountAsync(cancellationToken);

        // 2. Direct SQL Server Page Selection (24 items only)
        var rawProducts = await query
            .OrderByDescending(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(p => new
            {
                p.Id,
                p.ProductName,
                p.ProductNameTr,
                p.ProductCode,
                p.Impacode,
                p.Issacode,
                p.PartNo,
                p.SpecialCode,
                p.DrawingNo,
                p.Brand,
                p.Model,
                p.Description,
                p.Remarks,
                p.Category,
                p.SubCategory,
                p.CategoryId,
                p.ProductCategoryId,
                p.Unit,
                p.Foto,
                p.CompanyId,
                p.SaleActive,
                p.Rating
            })
            .ToListAsync(cancellationToken);

        if (!rawProducts.Any())
        {
            return new PagedResult<ProductDto>
            {
                Items = new List<ProductDto>(),
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        var productIds = rawProducts.Select(p => p.Id).ToList();
        var companyIds = rawProducts.Where(p => p.CompanyId.HasValue).Select(p => p.CompanyId!.Value).Distinct().ToList();

        // 3. Direct SQL Server Price query for only these 24 items
        var rawPrices = await _context.GnlProductPrices
            .AsNoTracking()
            .Where(pr => productIds.Contains(pr.StockId) && pr.IsDeleted != true)
            .Select(pr => new PriceBasicInfo
            {
                Id = pr.Id,
                StockId = pr.StockId,
                Price = pr.Price,
                Currency = pr.Currency
            })
            .ToListAsync(cancellationToken);

        var pricesDict = rawPrices
            .GroupBy(pr => pr.StockId)
            .ToDictionary(g => g.Key, g => g.OrderByDescending(pr => pr.Id).First());

        // 4. Direct SQL Server Company query for only these companies
        var companiesDict = companyIds.Any()
            ? await _context.GnlCompanies
                .AsNoTracking()
                .Where(c => companyIds.Contains(c.Id))
                .Select(c => new
                {
                    c.Id,
                    c.CompanyName,
                    c.ShortName,
                    c.City,
                    c.Country,
                    c.Active
                })
                .ToDictionaryAsync(c => c.Id, c => new CompanyBasicInfo 
                { 
                    CompanyName = c.CompanyName, 
                    ShortName = c.ShortName, 
                    City = c.City, 
                    Country = c.Country, 
                    Active = c.Active 
                }, cancellationToken)
            : new Dictionary<int, CompanyBasicInfo>();

        // 5. In-memory assembly of the 24 items
        var products = rawProducts.Select(p => {
            var comp = p.CompanyId.HasValue && companiesDict.TryGetValue(p.CompanyId.Value, out var cVal) ? cVal : null;
            pricesDict.TryGetValue(p.Id, out var prVal);

            var ports = new List<string>();
            if (comp != null && !string.IsNullOrEmpty(comp.City))
            {
                ports.Add(comp.City);
            }
            if (ports.Count == 0)
            {
                ports.AddRange(new[] { "Tuzla", "Rotterdam", "Singapore" });
            }

            return new ProductDto
            {
                Id = p.Id,
                Title = p.ProductName ?? p.ProductNameTr ?? p.ProductCode ?? $"Marine Item #{p.Id}",
                ImpaCode = p.Impacode,
                IssaCode = p.Issacode,
                OemPartNo = p.PartNo ?? p.SpecialCode ?? p.DrawingNo,
                Brand = p.Brand ?? "OEM Standard",
                Model = p.Model,
                Description = p.Description ?? p.Remarks ?? "Certified marine technical supply with international class standard compliance.",
                Category = p.Category ?? p.SubCategory ?? "Deck & Engine Supplies",
                CategoryId = p.CategoryId ?? p.ProductCategoryId,
                Unit = p.Unit ?? "Pcs",
                Image = !string.IsNullOrEmpty(p.Foto) ? p.Foto : "/images/hero-bg.jpg",
                Price = prVal != null ? prVal.Price : null,
                Currency = prVal?.Currency ?? "USD",
                Condition = "Brand New (OEM)",
                CompanyId = p.CompanyId,
                SupplierName = comp?.CompanyName ?? comp?.ShortName ?? "TRC Marine / Global Stockist",
                SupplierLocation = comp != null ? $"{comp.City ?? "Tuzla"}, {comp.Country ?? "Turkey"}" : "Tuzla / Istanbul, Turkey",
                IsVerified = comp?.Active != false,
                InStock = p.SaleActive != false,
                Rating = p.Rating ?? 4.8m,
                DeliveryPorts = ports,
                ClassApprovals = new List<string> { "DNV", "MED Wheelmark", "ABS", "ClassNK" }
            };
        }).ToList();

        return new PagedResult<ProductDto>
        {
            Items = products,
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }
}
