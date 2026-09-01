using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmCalibrationMeasurement
{
    public int Id { get; set; }

    public int CalibrationId { get; set; }

    public string Parameter { get; set; } = null!;

    public string? Unit { get; set; }

    public decimal ReferenceValue { get; set; }

    public decimal MeasuredValue { get; set; }

    public decimal Min { get; set; }

    public decimal Max { get; set; }

    public decimal Tolerance { get; set; }

    public decimal Deviation { get; set; }

    public string Result { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
