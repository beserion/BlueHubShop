using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvStockOnHand
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int StockId { get; set; }

    public int? WarehouseId { get; set; }

    public int? VesselWarehouseId { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNo { get; set; }

    public decimal? Qty { get; set; }

    public decimal? ReservedQty { get; set; }

    public decimal? AvailableQty { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalValue { get; set; }

    public string? Location { get; set; }

    public DateTime? LastMovementDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ValuationMethod { get; set; }

    public decimal? AvgCost { get; set; }

    public DateTime? LastRecalcDate { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvWarehouse? Warehouse { get; set; }
}
