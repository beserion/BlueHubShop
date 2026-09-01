using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinCreditCardTransaction
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int CreditCardId { get; set; }

    public string TransactionType { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; } = null!;

    public decimal? CurrencyRate { get; set; }

    public decimal AmountTl { get; set; }

    public string? Description { get; set; }

    public string? RefNo { get; set; }

    public int? PartnerId { get; set; }

    public int? VoucherId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
