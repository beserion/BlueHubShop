using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinVoucher
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? InvoiceId { get; set; }

    public int? RefId { get; set; }

    public int? RefModule { get; set; }

    public string? RefNo { get; set; }

    public string? DocNo { get; set; }

    public string? VoucherNo { get; set; }

    public DateOnly? VoucherDate { get; set; }

    public int? VoucherType { get; set; }

    public string? Description { get; set; }

    public string? Currency { get; set; }

    public decimal? CurrencyRate { get; set; }

    public string? Status { get; set; }

    public decimal? TotalDebit { get; set; }

    public decimal? TotalCredit { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsLocked { get; set; }

    public bool? IsReversal { get; set; }

    public int? ReversedVoucherId { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ProjectId { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public int CurrentStepOrder { get; set; }

    public int? PurchaseOrderId { get; set; }

    public int ApprovalStatus { get; set; }

    public virtual ICollection<FinVoucherLine> FinVoucherLines { get; set; } = new List<FinVoucherLine>();

    public virtual OprProject? Project { get; set; }
}
