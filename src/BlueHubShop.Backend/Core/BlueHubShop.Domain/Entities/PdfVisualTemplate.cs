using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class PdfVisualTemplate
{
    public int Id { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? IdentifierKeywords { get; set; }

    public string? HeaderZonesJson { get; set; }

    public string? TableZoneJson { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? SamplePdfPath { get; set; }
}
