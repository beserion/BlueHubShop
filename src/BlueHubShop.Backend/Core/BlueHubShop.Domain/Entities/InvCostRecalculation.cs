using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvCostRecalculation
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public DateTime RecalcDate { get; set; }

    public string RecalcType { get; set; } = null!;

    public int? StockId { get; set; }

    public int? WarehouseId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int RecordsProcessed { get; set; }

    public int VariancesFound { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvWarehouse? Warehouse { get; set; }
}
