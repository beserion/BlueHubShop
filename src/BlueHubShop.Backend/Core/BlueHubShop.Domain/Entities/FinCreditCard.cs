using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinCreditCard
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string CardName { get; set; } = null!;

    public string CardNo { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string CardholderName { get; set; } = null!;

    public string CardType { get; set; } = null!;

    public decimal CreditLimit { get; set; }

    public decimal AvailableLimit { get; set; }

    public string? Currency { get; set; }

    public int CutOffDay { get; set; }

    public int DueDay { get; set; }

    public string? GlAccountCode { get; set; }

    public bool? Active { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
