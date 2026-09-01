using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinVoucherLine
{
    public int Id { get; set; }

    public int? VoucherId { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? RefId { get; set; }

    public int? RefModule { get; set; }

    public string? DocNo { get; set; }

    public int? AccountPlanId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? CounterAccount { get; set; }

    public bool? IsCounterAccount { get; set; }

    public string? Currency { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? Debit { get; set; }

    public decimal? DebitTl { get; set; }

    public decimal? Credit { get; set; }

    public decimal? CreditTl { get; set; }

    public decimal? BalanceTl { get; set; }

    public decimal? Balance { get; set; }

    public string? Explanation { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual FinVoucher? Voucher { get; set; }
}
