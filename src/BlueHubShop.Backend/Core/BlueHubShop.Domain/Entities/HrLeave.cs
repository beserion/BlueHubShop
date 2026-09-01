using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrLeave
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public int LeaveTypeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public decimal TotalDays { get; set; }

    public string? Reason { get; set; }

    public int Status { get; set; }

    public int? ApprovedById { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? ApprovalNotes { get; set; }

    public string? DocumentPath { get; set; }

    public int? DeputyEmployeeId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public int CurrentStepOrder { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrLeaveType LeaveType { get; set; } = null!;
}
