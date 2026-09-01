using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinChequeTransaction
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ChequeId { get; set; }

    public string? FromStatus { get; set; }

    public string ToStatus { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public int? PartnerId { get; set; }

    public int? BankAccountId { get; set; }

    public string? Description { get; set; }

    public int? VoucherId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
