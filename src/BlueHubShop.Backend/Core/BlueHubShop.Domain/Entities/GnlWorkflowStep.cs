using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlWorkflowStep
{
    public int Id { get; set; }

    public int TemplateId { get; set; }

    public int StepOrder { get; set; }

    public string? StepName { get; set; }

    public string? RequiredRoleName { get; set; }

    public string? RejectAction { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public string? ApproverType { get; set; }

    public string? ConditionQuery { get; set; }

    public string? EscalationRoleName { get; set; }

    public bool IsParallel { get; set; }

    public decimal? MaxAmount { get; set; }

    public decimal? MinAmount { get; set; }

    public int? ParallelGroupId { get; set; }

    public string? SpecificUserId { get; set; }

    public string? TimeoutAction { get; set; }

    public int? TimeoutDays { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual GnlWorkflowTemplate Template { get; set; } = null!;
}
