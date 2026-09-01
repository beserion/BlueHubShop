using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OprProjectDeliverable
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ProjectId { get; set; }

    public int? ProjectPhaseId { get; set; }

    public string Name { get; set; } = null!;

    public string? DeliverableType { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? DeliveredDate { get; set; }

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual OprProject Project { get; set; } = null!;

    public virtual OprProjectPhase? ProjectPhase { get; set; }
}
