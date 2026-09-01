using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiPromptTemplate
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string TemplateCode { get; set; } = null!;

    public string TemplateName { get; set; } = null!;

    public string? SystemPrompt { get; set; }

    public string? UserPromptTemplate { get; set; }

    public string? LanguageCode { get; set; }

    public int VersionNo { get; set; }

    public bool IsDefault { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
