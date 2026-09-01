using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvGoodsReceipt
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? WarehouseId { get; set; }

    public int? ShipmentId { get; set; }

    public int? PurchaseOrderId { get; set; }

    public string? DocumentNo { get; set; }

    public DateTime? DocumentDate { get; set; }

    public string? SupplierInvoiceNo { get; set; }

    public DateTime? SupplierInvoiceDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? PostedByUserId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ProjectId { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? CurrentApprovalStep { get; set; }

    public string? DeliveredBy { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? ReceivedBy { get; set; }

    public string? RejectionReason { get; set; }

    public int? VoucherId { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public string? WaybillNo { get; set; }

    public DateTime? WaybillDate { get; set; }

    public string? RfqNo { get; set; }

    public string? ProjectNo { get; set; }

    public int ApprovalStatus { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual ICollection<InvGoodsReceiptLine> InvGoodsReceiptLines { get; set; } = new List<InvGoodsReceiptLine>();

    public virtual ICollection<InvLandedCost> InvLandedCosts { get; set; } = new List<InvLandedCost>();

    public virtual ICollection<InvReturnsToSupplier> InvReturnsToSuppliers { get; set; } = new List<InvReturnsToSupplier>();

    public virtual OprProject? Project { get; set; }

    public virtual InvWarehouse? Warehouse { get; set; }
}
