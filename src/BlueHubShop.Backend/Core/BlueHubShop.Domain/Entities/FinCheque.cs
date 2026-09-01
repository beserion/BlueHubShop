using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinCheque
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? ChequeType { get; set; }

    public string? ChequeNo { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? AccountNumber { get; set; }

    public string? IbanNo { get; set; }

    public string? IssuerName { get; set; }

    public string? ReceiverName { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? IssueDate { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? AmountTl { get; set; }

    public string? CurrentStatus { get; set; }

    public string? GlAccountCode { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
