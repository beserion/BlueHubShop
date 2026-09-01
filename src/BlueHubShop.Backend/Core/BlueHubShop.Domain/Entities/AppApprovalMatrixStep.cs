using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppApprovalMatrixStep
{
    public int Id { get; set; }

    public int ApprovalMatrixId { get; set; }

    public int Sequence { get; set; }

    public int? ApprovalLevelId { get; set; }

    public string? RequiredRoleId { get; set; }

    public int? RequiredClaimId { get; set; }

    public int RequiredApprovalCount { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public string? StepName { get; set; }

    public virtual AppApprovalLevel? ApprovalLevel { get; set; }

    public virtual AppApprovalMatrix ApprovalMatrix { get; set; } = null!;

    public virtual GnlCompany? Company { get; set; }

    public virtual AppClaim? RequiredClaim { get; set; }
}
