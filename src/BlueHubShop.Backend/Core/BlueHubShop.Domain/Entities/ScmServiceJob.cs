using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmServiceJob
{
    public int Id { get; set; }

    public string JobNo { get; set; } = null!;

    public int WorkOrderId { get; set; }

    public int TechnicianId { get; set; }

    public DateTime ActualStart { get; set; }

    public DateTime? ActualEnd { get; set; }

    public decimal LaborHours { get; set; }

    public string? WorkPerformed { get; set; }

    public string? MaterialsUsed { get; set; }

    public string? MeasurementsNotes { get; set; }

    public string? TechnicianNotes { get; set; }

    public string? CustomerNotes { get; set; }

    public string? TechnicianSignature { get; set; }

    public string? CustomerSignature { get; set; }

    public string? SignedBy { get; set; }

    public DateTime? SignedDate { get; set; }

    public string? SignatureIpAddress { get; set; }

    public string? SignatureUserAgent { get; set; }

    public string? SignatureDocumentHash { get; set; }

    public string Status { get; set; } = null!;

    public int? ScmWorkOrderId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
