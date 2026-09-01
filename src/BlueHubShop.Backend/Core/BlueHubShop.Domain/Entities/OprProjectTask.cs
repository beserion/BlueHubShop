using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OprProjectTask
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int ProjectPhaseId { get; set; }

    public int? AssignedToPersonelId { get; set; }

    public int Sequence { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateOnly? PlannedStartDate { get; set; }

    public DateOnly? PlannedEndDate { get; set; }

    public DateOnly? ActualStartDate { get; set; }

    public DateOnly? ActualEndDate { get; set; }

    public decimal? BudgetAmount { get; set; }

    public string? Status { get; set; }

    public decimal? ProgressPercent { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual OprProjectPhase ProjectPhase { get; set; } = null!;
}
