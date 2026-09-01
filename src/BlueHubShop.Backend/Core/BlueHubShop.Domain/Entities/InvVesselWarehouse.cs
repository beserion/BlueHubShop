using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvVesselWarehouse
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int VesselId { get; set; }

    public string WarehouseCode { get; set; } = null!;

    public string WarehouseName { get; set; } = null!;

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<InvAnnualCount> InvAnnualCounts { get; set; } = new List<InvAnnualCount>();

    public virtual ICollection<InvCycleCount> InvCycleCounts { get; set; } = new List<InvCycleCount>();

    public virtual ICollection<InvExpiryTracking> InvExpiryTrackings { get; set; } = new List<InvExpiryTracking>();

    public virtual ICollection<InvGoodsIssue> InvGoodsIssues { get; set; } = new List<InvGoodsIssue>();

    public virtual ICollection<InvMinimumStockAlert> InvMinimumStockAlerts { get; set; } = new List<InvMinimumStockAlert>();

    public virtual ICollection<InvStockTransfer> InvStockTransferFromVesselWarehouses { get; set; } = new List<InvStockTransfer>();

    public virtual ICollection<InvStockTransfer> InvStockTransferToVesselWarehouses { get; set; } = new List<InvStockTransfer>();

    public virtual ICollection<InvVarianceReport> InvVarianceReports { get; set; } = new List<InvVarianceReport>();

    public virtual GnlVessel Vessel { get; set; } = null!;
}
