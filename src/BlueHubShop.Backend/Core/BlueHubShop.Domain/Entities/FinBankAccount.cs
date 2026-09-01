using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinBankAccount
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? Grup { get; set; }

    public string? Category { get; set; }

    public string? Currency { get; set; }

    public string? AccountNo { get; set; }

    public string? IbanNo { get; set; }

    public string? SwiftCode { get; set; }

    public decimal? Balance { get; set; }

    public decimal? LastBalance { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Logo { get; set; }

    public string? IconName { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
