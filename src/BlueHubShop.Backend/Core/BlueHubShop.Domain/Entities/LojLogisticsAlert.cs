using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojLogisticsAlert
{
    public int Id { get; set; }

    public string AlertNo { get; set; } = null!;

    public DateTime AlertDate { get; set; }

    public string? AlertType { get; set; }

    public string? Severity { get; set; }

    public string? Status { get; set; }

    public string? Subject { get; set; }

    public string? Description { get; set; }

    public string? EntityType { get; set; }

    public int? EntityId { get; set; }

    public int? AssignedToUserId { get; set; }

    public DateTime? AcknowledgedAt { get; set; }

    public DateTime? ResolvedAt { get; set; }

    public string? Resolution { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
