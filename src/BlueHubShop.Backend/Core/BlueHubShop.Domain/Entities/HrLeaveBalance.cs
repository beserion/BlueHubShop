using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrLeaveBalance
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public int LeaveTypeId { get; set; }

    public int Year { get; set; }

    public decimal EntitledDays { get; set; }

    public decimal UsedDays { get; set; }

    public decimal CarriedForwardDays { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrLeaveType LeaveType { get; set; } = null!;
}
