using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrEmployeeSalaryDefinition
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public int SalaryComponentId { get; set; }

    public decimal Amount { get; set; }

    public bool IsFixed { get; set; }

    public int CalcType { get; set; }

    public decimal? Percentage { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrSalaryComponent SalaryComponent { get; set; } = null!;
}
