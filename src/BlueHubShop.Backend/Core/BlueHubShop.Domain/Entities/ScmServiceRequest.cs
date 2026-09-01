using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmServiceRequest
{
    public int Id { get; set; }

    public string RequestNo { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public int PartnerId { get; set; }

    public int? CustomerSiteId { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }

    public int? AssetId { get; set; }

    public int? ServiceTypeId { get; set; }

    public string Priority { get; set; } = null!;

    public DateTime RequestedDate { get; set; }

    public DateTime? PreferredServiceDate { get; set; }

    public string? Description { get; set; }

    public string? CustomerReference { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public int? AssignedTechnicianId { get; set; }

    public string Status { get; set; } = null!;

    public string? InternalNotes { get; set; }

    public string? CustomerNotes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
