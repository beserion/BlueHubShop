using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvWarehouse
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public int CompanyId { get; set; }

    public string WarehouseCode { get; set; } = null!;

    public string WarehouseName { get; set; } = null!;

    public int? WarehouseType { get; set; }

    public string? Address { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Town { get; set; }

    public string? PostalCode { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? ContactPerson { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? Height { get; set; }

    public decimal? Capacity { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<InvAnnualCount> InvAnnualCounts { get; set; } = new List<InvAnnualCount>();

    public virtual ICollection<InvBatchSerial> InvBatchSerials { get; set; } = new List<InvBatchSerial>();

    public virtual ICollection<InvCostRecalculation> InvCostRecalculations { get; set; } = new List<InvCostRecalculation>();

    public virtual ICollection<InvCycleCount> InvCycleCounts { get; set; } = new List<InvCycleCount>();

    public virtual ICollection<InvExpiryTracking> InvExpiryTrackings { get; set; } = new List<InvExpiryTracking>();

    public virtual ICollection<InvFifolot> InvFifolots { get; set; } = new List<InvFifolot>();

    public virtual ICollection<InvGoodsIssue> InvGoodsIssues { get; set; } = new List<InvGoodsIssue>();

    public virtual ICollection<InvGoodsReceipt> InvGoodsReceipts { get; set; } = new List<InvGoodsReceipt>();

    public virtual ICollection<InvInterDepotTransfer> InvInterDepotTransferFromWarehouses { get; set; } = new List<InvInterDepotTransfer>();

    public virtual ICollection<InvInterDepotTransfer> InvInterDepotTransferToWarehouses { get; set; } = new List<InvInterDepotTransfer>();

    public virtual ICollection<InvMinimumStockAlert> InvMinimumStockAlerts { get; set; } = new List<InvMinimumStockAlert>();

    public virtual ICollection<InvReturnsFromVessel> InvReturnsFromVessels { get; set; } = new List<InvReturnsFromVessel>();

    public virtual ICollection<InvReturnsToSupplier> InvReturnsToSuppliers { get; set; } = new List<InvReturnsToSupplier>();

    public virtual ICollection<InvStockMovement> InvStockMovements { get; set; } = new List<InvStockMovement>();

    public virtual ICollection<InvStockOnHand> InvStockOnHands { get; set; } = new List<InvStockOnHand>();

    public virtual ICollection<InvStockTransfer> InvStockTransferFromWarehouses { get; set; } = new List<InvStockTransfer>();

    public virtual ICollection<InvStockTransfer> InvStockTransferToWarehouses { get; set; } = new List<InvStockTransfer>();

    public virtual ICollection<InvValuationMethod> InvValuationMethods { get; set; } = new List<InvValuationMethod>();

    public virtual ICollection<InvVarianceReport> InvVarianceReports { get; set; } = new List<InvVarianceReport>();
}
