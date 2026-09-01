using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrContract
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public string ContractNo { get; set; } = null!;

    public int ContractType { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal GrossSalary { get; set; }

    public string Currency { get; set; } = null!;

    public int PaymentPeriod { get; set; }

    public int WorkingHoursPerWeek { get; set; }

    public int AnnualLeaveDays { get; set; }

    public string? Benefits { get; set; }

    public string? SpecialTerms { get; set; }

    public int Status { get; set; }

    public string? DocumentPath { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;
}
