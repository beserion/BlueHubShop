namespace BlueHubShop.Application.DTOs;

public class ProductDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? ImpaCode { get; set; }
    public string? IssaCode { get; set; }
    public string? OemPartNo { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public int? CategoryId { get; set; }
    public string? Unit { get; set; }
    public string? Image { get; set; }
    public decimal? Price { get; set; }
    public string Currency { get; set; } = "USD";
    public string Condition { get; set; } = "Brand New (OEM)";
    public int? CompanyId { get; set; }
    public string? SupplierName { get; set; }
    public string? SupplierLocation { get; set; }
    public bool IsVerified { get; set; } = true;
    public bool InStock { get; set; } = true;
    public decimal? Rating { get; set; }
    public List<string> DeliveryPorts { get; set; } = new();
    public List<string> ClassApprovals { get; set; } = new();
}
