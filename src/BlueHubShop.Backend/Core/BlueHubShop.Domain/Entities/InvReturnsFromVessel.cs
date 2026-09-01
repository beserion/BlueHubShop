using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvReturnsFromVessel
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string DocumentNo { get; set; } = null!;

    public DateTime DocumentDate { get; set; }

    public int? VesselWarehouseId { get; set; }

    public int ToWarehouseId { get; set; }

    public int? GoodsIssueId { get; set; }

    public string Status { get; set; } = null!;

    public string? Reason { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? PostedByUserId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvGoodsIssue? GoodsIssue { get; set; }

    public virtual ICollection<InvReturnFromVesselLine> InvReturnFromVesselLines { get; set; } = new List<InvReturnFromVesselLine>();

    public virtual InvWarehouse ToWarehouse { get; set; } = null!;
}
