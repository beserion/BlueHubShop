using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VStockBrand
{
    public string? StockCode { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? PartNo { get; set; }

    public string? ItemNo { get; set; }

    public string? Currency { get; set; }

    public int? StockCount { get; set; }

    public double? ApriceMax { get; set; }

    public double? SpriceMax { get; set; }

    public double? ApriceAvg { get; set; }

    public double? SpriceAvg { get; set; }
}
