using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvGoodsIssue
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string DocumentNo { get; set; } = null!;

    public DateTime DocumentDate { get; set; }

    public int WarehouseId { get; set; }

    public int? VesselWarehouseId { get; set; }

    public int? RequisitionId { get; set; }

    public int? ProjectId { get; set; }

    public string IssueType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? PostedByUserId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? CargoCompanyId { get; set; }

    public int? CurrentApprovalStep { get; set; }

    public string? DeliveredBy { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? PartnerId { get; set; }

    public string? ReceivedBy { get; set; }

    public string? ReceivedByName { get; set; }

    public string? RejectionReason { get; set; }

    public int? RequestedByUserId { get; set; }

    public string? ShippingMethod { get; set; }

    public string? TrackingNumber { get; set; }

    public string? VehiclePlateNo { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public int ApprovalStatus { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<InvGoodsIssueLine> InvGoodsIssueLines { get; set; } = new List<InvGoodsIssueLine>();

    public virtual ICollection<InvReturnsFromVessel> InvReturnsFromVessels { get; set; } = new List<InvReturnsFromVessel>();

    public virtual OprProject? Project { get; set; }

    public virtual InvVesselWarehouse? VesselWarehouse { get; set; }

    public virtual InvWarehouse Warehouse { get; set; } = null!;
}
