using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinInvoicePayment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int InvoiceId { get; set; }

    public int PaymentId { get; set; }

    public int? VoucherId { get; set; }

    public decimal PaidAmount { get; set; }

    public DateTime PaidDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
