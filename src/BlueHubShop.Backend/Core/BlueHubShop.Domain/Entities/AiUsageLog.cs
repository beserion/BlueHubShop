using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiUsageLog
{
    public long Id { get; set; }

    public int CompanyId { get; set; }

    public int? BranchId { get; set; }

    public int? VesselId { get; set; }

    public string UserId { get; set; } = null!;

    public int? AgentId { get; set; }

    public int? ProviderId { get; set; }

    public int? ModelId { get; set; }

    public string? RequestText { get; set; }

    public string? ResponseText { get; set; }

    public int? PromptTokens { get; set; }

    public int? CompletionTokens { get; set; }

    public int? TotalTokens { get; set; }

    public decimal? EstimatedCost { get; set; }

    public int? ExecutionTimeMs { get; set; }

    public string? ExecutionStatus { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime CreatedDate { get; set; }
}
