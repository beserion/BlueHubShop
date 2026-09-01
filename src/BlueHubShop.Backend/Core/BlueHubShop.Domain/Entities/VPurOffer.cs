using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VPurOffer
{
    public int Id { get; set; }

    public int RequestId { get; set; }

    public int PartnerId { get; set; }

    public double? Freight { get; set; }

    public double? Insurance { get; set; }

    public string? Status { get; set; }

    public int? DetailId { get; set; }

    public int? StockId { get; set; }

    public string? PstockCode { get; set; }

    public string? PstockName { get; set; }

    public double? Qty { get; set; }

    public double? Price { get; set; }

    public string? Currency { get; set; }

    public bool? IsSelected { get; set; }

    public bool? IsDeleted { get; set; }
}
