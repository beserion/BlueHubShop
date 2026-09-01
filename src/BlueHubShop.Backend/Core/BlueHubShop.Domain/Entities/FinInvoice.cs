using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinInvoice
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public int? PartnerId { get; set; }

    public int? BranchId { get; set; }

    public int? VoucherId { get; set; }

    public int? VoucherType { get; set; }

    public int? InvoiceType { get; set; }

    public string? DocumentNo { get; set; }

    public string? Description { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public string? Currency { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? DscTotal { get; set; }

    public decimal? NetTotal { get; set; }

    public decimal? VatTotal { get; set; }

    public decimal? GnlTotal { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? RemainingAmount { get; set; }

    public int IsPaid { get; set; }

    public bool? IsClosed { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ProjectId { get; set; }

    public int? PurchaseOrderId { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public int CurrentStepOrder { get; set; }

    public bool IsLocked { get; set; }

    public bool IsPosted { get; set; }

    public string? InvoiceProfile { get; set; }

    public string? InvoiceScenario { get; set; }

    public string? RfqNo { get; set; }

    public string? ProjectNo { get; set; }

    public virtual OprProject? Project { get; set; }
}
