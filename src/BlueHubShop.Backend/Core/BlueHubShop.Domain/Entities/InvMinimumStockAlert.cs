using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvMinimumStockAlert
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int StockId { get; set; }

    public int? WarehouseId { get; set; }

    public int? VesselWarehouseId { get; set; }

    public decimal MinQty { get; set; }

    public decimal CurrentQty { get; set; }

    public decimal ReorderQty { get; set; }

    public bool IsActive { get; set; }

    public bool IsAlerted { get; set; }

    public DateTime? LastAlertDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvVesselWarehouse? VesselWarehouse { get; set; }

    public virtual InvWarehouse? Warehouse { get; set; }
}
