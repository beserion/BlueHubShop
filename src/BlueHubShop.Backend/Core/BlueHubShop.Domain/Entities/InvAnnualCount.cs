using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvAnnualCount
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string DocumentNo { get; set; } = null!;

    public DateTime CountDate { get; set; }

    public int Year { get; set; }

    public int WarehouseId { get; set; }

    public int? VesselWarehouseId { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int? CompletedByUserId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<InvAnnualCountLine> InvAnnualCountLines { get; set; } = new List<InvAnnualCountLine>();

    public virtual ICollection<InvVarianceReport> InvVarianceReports { get; set; } = new List<InvVarianceReport>();

    public virtual InvVesselWarehouse? VesselWarehouse { get; set; }

    public virtual InvWarehouse Warehouse { get; set; } = null!;
}
