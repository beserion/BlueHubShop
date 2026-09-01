using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FncAccountTransaction
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? AccountPlanId { get; set; }

    public string? AccountCode { get; set; }

    public DateOnly? TransDate { get; set; }

    public string? RefModule { get; set; }

    public int? RefId { get; set; }

    public string? DocNo { get; set; }

    public string? RefNo { get; set; }

    public string? Currency { get; set; }

    public double? CurrencyRate { get; set; }

    public decimal? Debit { get; set; }

    public decimal? DebitTl { get; set; }

    public decimal? Credit { get; set; }

    public decimal? CreditTl { get; set; }

    public decimal? AmountTl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Remarks { get; set; }

    public int? VoucherId { get; set; }

    public int? VoucherLineId { get; set; }
}
