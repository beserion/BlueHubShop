using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmServiceChecklistResult
{
    public int Id { get; set; }

    public int ServiceJobId { get; set; }

    public int CheckItemId { get; set; }

    public string Result { get; set; } = null!;

    public string? MeasuredValue { get; set; }

    public string? ExpectedValue { get; set; }

    public string? Tolerance { get; set; }

    public string? TechnicianNote { get; set; }

    public string? CustomerNote { get; set; }

    public bool HasEvidence { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
