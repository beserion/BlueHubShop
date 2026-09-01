using MediatR;
using Microsoft.EntityFrameworkCore;
using BlueHubShop.Application.Common.Interfaces;
using BlueHubShop.Application.DTOs;

namespace BlueHubShop.Application.Features.Products.Queries;

public record GetProductByIdQuery(int Id) : IRequest<ProductDetailDto?>;

public class ProductDetailDto : ProductDto
{
    public string? DrawingNo { get; set; }
    public string? Barcode { get; set; }
    public string? ItemNo { get; set; }
    public decimal? Volume { get; set; }
    public decimal? Weight { get; set; }
    public string? Origin { get; set; }
    public int? Gtip { get; set; }
    public decimal? MinQty { get; set; }
    public decimal? MaxQty { get; set; }
    public string? Remarks { get; set; }
    public DateTime? CreatedDate { get; set; }

    public CompanyDetailDto? Company { get; set; }
    public List<ProductSpecDto> Specifications { get; set; } = new();
}

public class CompanyDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? CompanyType { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Address { get; set; }
    public string? OfficePhone { get; set; }
    public string? EmailAddress { get; set; }
    public string? WebAddress { get; set; }
    public string? Description { get; set; }
    public bool IsVerified { get; set; } = true;
    public decimal Rating { get; set; } = 4.9m;
}

public class ProductSpecDto
{
    public string Key { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDetailDto?>
{
    private readonly IApplicationDbContext _context;

    public GetProductByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ProductDetailDto?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var p = await _context.GnlProducts
            .AsNoTracking()
            .FirstOrDefaultAsync(item => item.Id == request.Id && item.IsDeleted != true, cancellationToken);

        if (p == null) return null;

        var price = await _context.GnlProductPrices
            .AsNoTracking()
            .Where(pr => pr.StockId == p.Id && !pr.IsDeleted)
            .OrderByDescending(pr => pr.Id)
            .FirstOrDefaultAsync(cancellationToken);

        var comp = p.CompanyId.HasValue
            ? await _context.GnlCompanies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == p.CompanyId.Value, cancellationToken)
            : null;

        var specs = new List<ProductSpecDto>();
        if (!string.IsNullOrEmpty(p.Brand)) specs.Add(new ProductSpecDto { Key = "Manufacturer / Brand", Value = p.Brand });
        if (!string.IsNullOrEmpty(p.Model)) specs.Add(new ProductSpecDto { Key = "Model", Value = p.Model });
        if (!string.IsNullOrEmpty(p.PartNo)) specs.Add(new ProductSpecDto { Key = "OEM Part Number", Value = p.PartNo });
        if (!string.IsNullOrEmpty(p.DrawingNo)) specs.Add(new ProductSpecDto { Key = "Drawing Number", Value = p.DrawingNo });
        if (!string.IsNullOrEmpty(p.Impacode)) specs.Add(new ProductSpecDto { Key = "IMPA Code", Value = p.Impacode });
        if (!string.IsNullOrEmpty(p.Issacode)) specs.Add(new ProductSpecDto { Key = "ISSA Code", Value = p.Issacode });
        if (!string.IsNullOrEmpty(p.Origin)) specs.Add(new ProductSpecDto { Key = "Country of Origin", Value = p.Origin });
        if (!string.IsNullOrEmpty(p.Unit)) specs.Add(new ProductSpecDto { Key = "Standard Unit of Measure", Value = p.Unit });
        if (p.Weight.HasValue && p.Weight > 0) specs.Add(new ProductSpecDto { Key = "Gross Weight", Value = $"{p.Weight:N2} kg" });
        if (p.Volume.HasValue && p.Volume > 0) specs.Add(new ProductSpecDto { Key = "Volume / Dimensions", Value = $"{p.Volume:N2} m³" });
        if (!string.IsNullOrEmpty(p.Barcode)) specs.Add(new ProductSpecDto { Key = "Barcode / GTIN", Value = p.Barcode });
        if (p.Gtip.HasValue) specs.Add(new ProductSpecDto { Key = "HS / GTIP Code", Value = p.Gtip.ToString()! });

        specs.Add(new ProductSpecDto { Key = "Class Approvals", Value = "DNV, MED Wheelmark, ABS, Bureau Veritas" });
        specs.Add(new ProductSpecDto { Key = "Condition", Value = "Brand New (OEM Standard) with Original Mill Test Certificate" });

        var ports = new List<string>();
        if (comp != null && !string.IsNullOrEmpty(comp.City)) ports.Add(comp.City);
        ports.AddRange(new[] { "Tuzla", "Rotterdam", "Singapore", "Hamburg", "Houston" });

        return new ProductDetailDto
        {
            Id = p.Id,
            Title = p.ProductName ?? p.ProductNameTr ?? p.ProductCode ?? $"Marine Item #{p.Id}",
            ImpaCode = p.Impacode,
            IssaCode = p.Issacode,
            OemPartNo = p.PartNo ?? p.SpecialCode ?? p.DrawingNo,
            Brand = p.Brand ?? "OEM Standard",
            Model = p.Model,
            Description = p.Description ?? p.Remarks ?? "Heavy-duty certified marine technical supply manufactured to international maritime class standards.",
            Category = p.Category ?? p.SubCategory ?? "Deck & Engine Supplies",
            CategoryId = p.CategoryId ?? p.ProductCategoryId,
            Unit = p.Unit ?? "Pcs",
            Image = !string.IsNullOrEmpty(p.Foto) ? p.Foto : "/images/hero-bg.jpg",
            Price = price?.Price,
            Currency = price?.Currency ?? "USD",
            Condition = "Brand New (OEM)",
            CompanyId = p.CompanyId,
            SupplierName = comp?.CompanyName ?? comp?.ShortName ?? "TRC Marine / Global Stockist",
            SupplierLocation = comp != null ? $"{comp.City ?? "Tuzla"}, {comp.Country ?? "Turkey"}" : "Tuzla / Istanbul, Turkey",
            IsVerified = comp?.Active != false,
            InStock = p.SaleActive != false,
            Rating = p.Rating ?? 4.8m,
            DeliveryPorts = ports.Distinct().ToList(),
            ClassApprovals = new List<string> { "DNV", "MED Wheelmark", "ABS", "ClassNK" },
            DrawingNo = p.DrawingNo,
            Barcode = p.Barcode,
            ItemNo = p.ItemNo,
            Volume = p.Volume,
            Weight = p.Weight,
            Origin = p.Origin,
            Gtip = p.Gtip,
            MinQty = p.MinQty,
            MaxQty = p.MaxQty,
            Remarks = p.Remarks,
            CreatedDate = p.CreatedDate,
            Specifications = specs,
            Company = comp != null ? new CompanyDetailDto
            {
                Id = comp.Id,
                Name = comp.CompanyName ?? "Marine Technical Supplier",
                CompanyType = comp.CompanyType ?? "Ship Chandler & Technical Stockist",
                City = comp.City ?? "Tuzla",
                Country = comp.Country ?? "Turkey",
                Address = comp.Address ?? comp.DeliveryAddress ?? "Tuzla Shipyard Area, Istanbul",
                EmailAddress = comp.EmailAddress,
                OfficePhone = comp.OfficePhone,
                WebAddress = comp.WebAddress,
                Description = comp.Description ?? "Certified global ship chandler and technical marine equipment supplier.",
                IsVerified = comp.Active != false,
                Rating = 4.9m
            } : null
        };
    }
}
