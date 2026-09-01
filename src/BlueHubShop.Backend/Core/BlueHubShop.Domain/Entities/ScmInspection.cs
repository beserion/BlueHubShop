using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmInspection
{
    public int Id { get; set; }

    public string InspectionNo { get; set; } = null!;

    public int PartnerId { get; set; }

    public int AssetId { get; set; }

    public int? ServiceJobId { get; set; }

    public string InspectionType { get; set; } = null!;

    public int InspectorId { get; set; }

    public DateTime InspectionDate { get; set; }

    public string? Findings { get; set; }

    public string? Recommendations { get; set; }

    public string Result { get; set; } = null!;

    public DateTime? NextInspectionDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
