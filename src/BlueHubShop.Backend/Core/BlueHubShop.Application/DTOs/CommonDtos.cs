namespace BlueHubShop.Application.DTOs;

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public int ProductCount { get; set; }
    public List<SubCategoryDto> Subcategories { get; set; } = new();
}

public class SubCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int ProductCount { get; set; }
}

public class CompanyDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? CompanyType { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? EmailAddress { get; set; }
    public string? OfficePhone { get; set; }
    public string? WebAddress { get; set; }
    public string? Description { get; set; }
    public bool IsVerified { get; set; } = true;
    public decimal Rating { get; set; } = 4.8m;
    public int ActiveProductsCount { get; set; }
    public List<string> Certifications { get; set; } = new();
    public List<string> MainPorts { get; set; } = new();
    public List<string> Languages { get; set; } = new();
}

public class ImpaGroupDto
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Count { get; set; }
    public List<string> SampleCodes { get; set; } = new();
}

public class CreateRfqRequestDto
{
    public int? ProductId { get; set; }
    public string VesselName { get; set; } = string.Empty;
    public string ImoNumber { get; set; } = string.Empty;
    public string PortOfDelivery { get; set; } = string.Empty;
    public DateTime? EtaDate { get; set; }
    public decimal Quantity { get; set; } = 1;
    public string? Notes { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactPhone { get; set; }
}
