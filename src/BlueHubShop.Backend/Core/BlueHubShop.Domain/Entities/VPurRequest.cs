using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VPurRequest
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? Status { get; set; }

    public string? DocumentNumber { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public int? DetailId { get; set; }

    public string? DetailStatus { get; set; }

    public int? StockId { get; set; }

    public string? StockCode { get; set; }

    public string? StockName { get; set; }

    public double? Qty { get; set; }
}
