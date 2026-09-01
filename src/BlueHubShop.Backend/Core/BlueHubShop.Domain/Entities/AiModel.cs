using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiModel
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ProviderId { get; set; }

    public string ModelCode { get; set; } = null!;

    public string ModelName { get; set; } = null!;

    public decimal? InputTokenPrice { get; set; }

    public decimal? OutputTokenPrice { get; set; }

    public int? MaxContextTokens { get; set; }

    public bool SupportsTools { get; set; }

    public bool SupportsVision { get; set; }

    public bool SupportsJson { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<AiAgent> AiAgents { get; set; } = new List<AiAgent>();

    public virtual AiProvider Provider { get; set; } = null!;
}
