using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvStockTransfer
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string DocumentNo { get; set; } = null!;

    public DateTime DocumentDate { get; set; }

    public int FromWarehouseId { get; set; }

    public int? FromVesselWarehouseId { get; set; }

    public int ToWarehouseId { get; set; }

    public int? ToVesselWarehouseId { get; set; }

    public string TransferType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? ExpectedReceiptDate { get; set; }

    public DateTime? ActualReceiptDate { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? PostedByUserId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvVesselWarehouse? FromVesselWarehouse { get; set; }

    public virtual InvWarehouse FromWarehouse { get; set; } = null!;

    public virtual ICollection<InvStockTransferLine> InvStockTransferLines { get; set; } = new List<InvStockTransferLine>();

    public virtual InvVesselWarehouse? ToVesselWarehouse { get; set; }

    public virtual InvWarehouse ToWarehouse { get; set; } = null!;
}
