using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrShift
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string ShiftName { get; set; } = null!;

    public string? ShiftCode { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public TimeOnly? BreakStartTime { get; set; }

    public TimeOnly? BreakEndTime { get; set; }

    public decimal TotalHours { get; set; }

    public bool IsNightShift { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrEmployeeShift> HrEmployeeShifts { get; set; } = new List<HrEmployeeShift>();
}
