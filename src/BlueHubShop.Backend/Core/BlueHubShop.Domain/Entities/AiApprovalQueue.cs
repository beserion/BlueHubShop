using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiApprovalQueue
{
    public long Id { get; set; }

    public int CompanyId { get; set; }

    public int BranchId { get; set; }

    public int? VesselId { get; set; }

    public int UserId { get; set; }

    public int? AgentId { get; set; }

    public string RequestText { get; set; } = null!;

    public string? ProposedOutput { get; set; }

    public string ApprovalStatus { get; set; } = null!;

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? RejectedReason { get; set; }

    public DateTime CreatedDate { get; set; }
}
