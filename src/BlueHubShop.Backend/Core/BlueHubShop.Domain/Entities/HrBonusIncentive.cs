using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrBonusIncentive
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public string BonusNo { get; set; } = null!;

    public DateTime BonusDate { get; set; }

    public int BonusType { get; set; }

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public decimal AmountTl { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? PeriodId { get; set; }

    public string? PeriodName { get; set; }

    public int Status { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentReference { get; set; }

    public int? PayrollId { get; set; }

    public int? ApprovedById { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrPayroll? Payroll { get; set; }
}
