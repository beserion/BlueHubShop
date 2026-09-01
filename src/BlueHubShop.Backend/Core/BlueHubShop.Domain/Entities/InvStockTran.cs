using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvStockTran
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ProductId { get; set; }

    public int? WarehouseId { get; set; }

    public DateOnly TranDate { get; set; }

    public int TranType { get; set; }

    public string? RefModule { get; set; }

    public int? RefId { get; set; }

    public string? RefNo { get; set; }

    public int InOut { get; set; }

    public decimal Qty { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Total { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
