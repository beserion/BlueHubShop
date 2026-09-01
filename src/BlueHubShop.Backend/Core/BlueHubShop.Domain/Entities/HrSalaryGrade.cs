using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrSalaryGrade
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string GradeCode { get; set; } = null!;

    public string GradeName { get; set; } = null!;

    public int Level { get; set; }

    public decimal MinSalary { get; set; }

    public decimal MaxSalary { get; set; }

    public string Currency { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public int SortOrder { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;
}
