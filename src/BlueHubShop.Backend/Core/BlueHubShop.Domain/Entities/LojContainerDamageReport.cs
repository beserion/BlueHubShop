using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojContainerDamageReport
{
    public int Id { get; set; }

    public string ReportNo { get; set; } = null!;

    public int ContainerId { get; set; }

    public DateOnly ReportDate { get; set; }

    public string? DamageType { get; set; }

    public string? DamageSeverity { get; set; }

    public string? DamageLocation { get; set; }

    public string? Description { get; set; }

    public decimal? RepairCost { get; set; }

    public string? Currency { get; set; }

    public string? Status { get; set; }

    public int? ReportedById { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Container Container { get; set; } = null!;
}
