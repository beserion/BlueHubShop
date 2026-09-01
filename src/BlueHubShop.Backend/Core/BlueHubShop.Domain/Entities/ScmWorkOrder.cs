using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmWorkOrder
{
    public int Id { get; set; }

    public string WorkOrderNo { get; set; } = null!;

    public int? ServiceRequestId { get; set; }

    public int PartnerId { get; set; }

    public int? CustomerSiteId { get; set; }

    public int AssetId { get; set; }

    public int ServiceTypeId { get; set; }

    public int? AssignedTechnicianId { get; set; }

    public DateTime PlannedStart { get; set; }

    public DateTime PlannedEnd { get; set; }

    public DateTime? ActualStart { get; set; }

    public DateTime? ActualEnd { get; set; }

    public string Priority { get; set; } = null!;

    public string? WorkDescription { get; set; }

    public string? SafetyInstructions { get; set; }

    public string? RequiredTools { get; set; }

    public string? RequiredParts { get; set; }

    public string? RequiredDocuments { get; set; }

    public string Status { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
