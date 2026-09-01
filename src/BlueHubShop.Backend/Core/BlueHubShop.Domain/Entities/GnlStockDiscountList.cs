using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlStockDiscountList
{
    public int Id { get; set; }

    public int? StockId { get; set; }

    public int? DiscountListId { get; set; }
}
