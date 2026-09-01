using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvVarianceReport
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string ReportNo { get; set; } = null!;

    public DateTime ReportDate { get; set; }

    public int? CycleCountId { get; set; }

    public int? AnnualCountId { get; set; }

    public int WarehouseId { get; set; }

    public int? VesselWarehouseId { get; set; }

    public string Status { get; set; } = null!;

    public decimal TotalVarianceAmount { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? ApprovedByUserId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual InvAnnualCount? AnnualCount { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvCycleCount? CycleCount { get; set; }

    public virtual ICollection<InvVarianceReportLine> InvVarianceReportLines { get; set; } = new List<InvVarianceReportLine>();

    public virtual InvVesselWarehouse? VesselWarehouse { get; set; }

    public virtual InvWarehouse Warehouse { get; set; } = null!;
}
