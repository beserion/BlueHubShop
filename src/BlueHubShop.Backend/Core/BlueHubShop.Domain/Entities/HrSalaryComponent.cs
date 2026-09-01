using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrSalaryComponent
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string ComponentCode { get; set; } = null!;

    public string ComponentName { get; set; } = null!;

    public int ComponentType { get; set; }

    public bool IsPercentage { get; set; }

    public decimal? DefaultAmount { get; set; }

    public bool IsTaxable { get; set; }

    public bool IsSgk { get; set; }

    public bool IsRequired { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public int SortOrder { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool AffectsGross { get; set; }

    public bool AffectsNet { get; set; }

    public string? AccountCode { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrEmployeeSalaryDefinition> HrEmployeeSalaryDefinitions { get; set; } = new List<HrEmployeeSalaryDefinition>();

    public virtual ICollection<HrPayrollDetail> HrPayrollDetails { get; set; } = new List<HrPayrollDetail>();
}
