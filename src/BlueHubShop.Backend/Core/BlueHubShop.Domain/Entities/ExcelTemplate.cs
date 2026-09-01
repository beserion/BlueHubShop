using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ExcelTemplate
{
    public int Id { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? IdentifierKeywords { get; set; }

    public string? HeaderFieldsJson { get; set; }

    public string? TableFieldsJson { get; set; }

    public string? SampleExcelPath { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? CreatedBy { get; set; }
}
