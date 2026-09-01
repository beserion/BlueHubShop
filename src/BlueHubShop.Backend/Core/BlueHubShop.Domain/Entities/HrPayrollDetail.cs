using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrPayrollDetail
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int PayrollId { get; set; }

    public int SalaryComponentId { get; set; }

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrPayroll Payroll { get; set; } = null!;

    public virtual HrSalaryComponent SalaryComponent { get; set; } = null!;
}
