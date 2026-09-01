using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AipdfTemplate
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string IdentifierKeywords { get; set; } = null!;

    public string SystemPrompt { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }
}
