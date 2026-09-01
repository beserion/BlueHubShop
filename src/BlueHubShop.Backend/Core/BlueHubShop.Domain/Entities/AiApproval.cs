using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiApproval
{
    public long Id { get; set; }

    public int CompanyId { get; set; }

    public int? BranchId { get; set; }

    public int? VesselId { get; set; }

    public string RequestType { get; set; } = null!;

    public string OriginalInput { get; set; } = null!;

    public string Aioutput { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? ReviewerNote { get; set; }

    public string? ReviewedBy { get; set; }

    public DateTime? ReviewedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
