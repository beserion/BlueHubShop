using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrAttendance
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly AttendanceDate { get; set; }

    public DateTime? CheckInTime { get; set; }

    public DateTime? CheckOutTime { get; set; }

    public decimal? WorkedHours { get; set; }

    public decimal? OvertimeHours { get; set; }

    public int Status { get; set; }

    public string? CheckInLocation { get; set; }

    public string? CheckOutLocation { get; set; }

    public string? Notes { get; set; }

    public bool IsManualEntry { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;
}
