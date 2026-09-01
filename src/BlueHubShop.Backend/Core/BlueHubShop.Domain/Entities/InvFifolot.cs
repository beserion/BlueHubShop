using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvFifolot
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int StockId { get; set; }

    public int? WarehouseId { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNo { get; set; }

    public string? LotNo { get; set; }

    public DateTime EntryDate { get; set; }

    public decimal Qty { get; set; }

    public decimal UnitCost { get; set; }

    public decimal TotalCost { get; set; }

    public int? RefMovementId { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvStockMovement? RefMovement { get; set; }

    public virtual InvWarehouse? Warehouse { get; set; }
}
