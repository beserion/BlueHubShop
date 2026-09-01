using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiAgent
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string AgentCode { get; set; } = null!;

    public string AgentName { get; set; } = null!;

    public string? ModuleName { get; set; }

    public int? DefaultModelId { get; set; }

    public string? SystemPrompt { get; set; }

    public string? Description { get; set; }

    public bool RequireApproval { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual AiModel? DefaultModel { get; set; }
}
