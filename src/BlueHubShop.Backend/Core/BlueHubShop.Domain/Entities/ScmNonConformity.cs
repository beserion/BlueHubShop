using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmNonConformity
{
    public int Id { get; set; }

    public string Ncrno { get; set; } = null!;

    public int PartnerId { get; set; }

    public int AssetId { get; set; }

    public int? InspectionId { get; set; }

    public string Finding { get; set; } = null!;

    public string Severity { get; set; } = null!;

    public string? CorrectiveAction { get; set; }

    public string? ResponsiblePerson { get; set; }

    public DateTime? DueDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ClosedDate { get; set; }

    public string? ClosedBy { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
