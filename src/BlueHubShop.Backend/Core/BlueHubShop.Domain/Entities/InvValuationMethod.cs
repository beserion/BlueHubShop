using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvValuationMethod
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int? StockId { get; set; }

    public int? WarehouseId { get; set; }

    public string ValuationMethod { get; set; } = null!;

    public bool IsDefault { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvWarehouse? Warehouse { get; set; }
}
