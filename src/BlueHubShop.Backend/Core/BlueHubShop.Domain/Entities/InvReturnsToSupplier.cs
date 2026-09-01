using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvReturnsToSupplier
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string DocumentNo { get; set; } = null!;

    public DateTime DocumentDate { get; set; }

    public int WarehouseId { get; set; }

    public int PartnerId { get; set; }

    public int? GoodsReceiptId { get; set; }

    public string Status { get; set; } = null!;

    public string? Reason { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? PostedByUserId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? InvoiceId { get; set; }

    public int? VoucherId { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvGoodsReceipt? GoodsReceipt { get; set; }

    public virtual ICollection<InvReturnToSupplierLine> InvReturnToSupplierLines { get; set; } = new List<InvReturnToSupplierLine>();

    public virtual InvWarehouse Warehouse { get; set; } = null!;
}
