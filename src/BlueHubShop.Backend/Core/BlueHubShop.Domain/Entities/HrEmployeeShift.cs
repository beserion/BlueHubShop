using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrEmployeeShift
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public int ShiftId { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrShift Shift { get; set; } = null!;
}
