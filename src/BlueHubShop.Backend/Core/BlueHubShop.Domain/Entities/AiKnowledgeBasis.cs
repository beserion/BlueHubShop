using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiKnowledgeBasis
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? ModuleName { get; set; }

    public string KnowledgeType { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? SourceName { get; set; }

    public string? SourcePath { get; set; }

    public string? LanguageCode { get; set; }

    public bool IsActive { get; set; }

    public int VersionNo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<AiKnowledgeChunk> AiKnowledgeChunks { get; set; } = new List<AiKnowledgeChunk>();
}
