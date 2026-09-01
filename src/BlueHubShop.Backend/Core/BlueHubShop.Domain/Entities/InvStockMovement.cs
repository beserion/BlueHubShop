using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvStockMovement
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public DateTime MovementDate { get; set; }

    public string MovementType { get; set; } = null!;

    public string? RefModule { get; set; }

    public int? RefId { get; set; }

    public int StockId { get; set; }

    public int? WarehouseId { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNo { get; set; }

    public decimal Qty { get; set; }

    public decimal UnitCost { get; set; }

    public decimal TotalCost { get; set; }

    public string? Currency { get; set; }

    public decimal? CurrencyRate { get; set; }

    public string? ValuationMethod { get; set; }

    public decimal? BeforeQty { get; set; }

    public decimal? AfterQty { get; set; }

    public decimal? BeforeCost { get; set; }

    public decimal? AfterCost { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? ProjectId { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<InvFifolot> InvFifolots { get; set; } = new List<InvFifolot>();

    public virtual OprProject? Project { get; set; }

    public virtual InvWarehouse? Warehouse { get; set; }
}
