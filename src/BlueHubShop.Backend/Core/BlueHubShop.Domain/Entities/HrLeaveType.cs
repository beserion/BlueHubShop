using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrLeaveType
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string LeaveTypeName { get; set; } = null!;

    public string? LeaveTypeCode { get; set; }

    public bool IsPaid { get; set; }

    public int? MaxDaysPerYear { get; set; }

    public bool RequiresApproval { get; set; }

    public bool RequiresDocument { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrLeaveBalance> HrLeaveBalances { get; set; } = new List<HrLeaveBalance>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();
}
