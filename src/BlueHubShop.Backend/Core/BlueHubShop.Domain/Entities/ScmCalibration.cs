using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmCalibration
{
    public int Id { get; set; }

    public string CalibrationNo { get; set; } = null!;

    public int AssetId { get; set; }

    public string? SerialNumber { get; set; }

    public string CalibrationType { get; set; } = null!;

    public string? ReferenceStandard { get; set; }

    public DateTime CalibrationDate { get; set; }

    public DateTime? NextCalibrationDate { get; set; }

    public int TechnicianId { get; set; }

    public string? EnvironmentalConditions { get; set; }

    public string? Tolerance { get; set; }

    public string Result { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
