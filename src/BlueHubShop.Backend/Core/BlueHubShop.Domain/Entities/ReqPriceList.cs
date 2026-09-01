using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqPriceList
{
    public int Id { get; set; }

    public int StockId { get; set; }

    public string? Photo { get; set; }

    public string? StockCode { get; set; }

    public string? StockName { get; set; }

    public string? Unit { get; set; }

    public decimal Price { get; set; }
}
