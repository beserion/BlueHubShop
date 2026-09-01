using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinPaymentHeader
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? AccountId { get; set; }

    public int? VoucherId { get; set; }

    public string? VoucherNo { get; set; }

    public int? CashAccountId { get; set; }

    public int? BankAccountId { get; set; }

    public int? CariAccountId { get; set; }

    public int? PaymentType { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public string? DocNo { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? BankAccountCode { get; set; }

    public string? BankAccountName { get; set; }

    public string? CashAccountCode { get; set; }

    public string? CashAccountName { get; set; }

    public string? Currency { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountTl { get; set; }

    public int? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
