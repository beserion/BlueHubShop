using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojVesselFuelConsumption
{
    public int Id { get; set; }

    public int VesselId { get; set; }

    public DateOnly ReportDate { get; set; }

    public string? FuelType { get; set; }

    public decimal? Rob { get; set; }

    public decimal? Consumption { get; set; }

    public decimal? Bunkered { get; set; }

    public string? OperationMode { get; set; }

    public int? VoyageId { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlVessel Vessel { get; set; } = null!;
}
