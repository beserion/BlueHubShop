using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojRoutePort
{
    public int Id { get; set; }

    public int RouteId { get; set; }

    public int PortId { get; set; }

    public int Sequence { get; set; }

    public int? EstimatedDaysFromPrevious { get; set; }

    public string? OperationType { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlPort Port { get; set; } = null!;

    public virtual LojShippingRoute Route { get; set; } = null!;
}
