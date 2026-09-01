using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojShippingRoute
{
    public int Id { get; set; }

    public string RouteCode { get; set; } = null!;

    public string RouteName { get; set; } = null!;

    public string? RouteType { get; set; }

    public int? OriginPortId { get; set; }

    public int? DestinationPortId { get; set; }

    public int? EstimatedDays { get; set; }

    public decimal? Distance { get; set; }

    public decimal? BaseCost { get; set; }

    public string? Currency { get; set; }

    public bool? Active { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlPort? DestinationPort { get; set; }

    public virtual ICollection<LojRoutePort> LojRoutePorts { get; set; } = new List<LojRoutePort>();

    public virtual ICollection<LojShipment> LojShipments { get; set; } = new List<LojShipment>();

    public virtual GnlPort? OriginPort { get; set; }
}
