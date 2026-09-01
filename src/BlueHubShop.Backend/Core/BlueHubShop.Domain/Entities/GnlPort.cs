using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPort
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public bool? Active { get; set; }

    public string? Country { get; set; }

    public string? PortName { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? Description { get; set; }

    public string? Unctad { get; set; }

    public string? TimeZone { get; set; }

    public string? MaxDraft { get; set; }

    public string? MainPort { get; set; }

    public string? Authority { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? WebSide { get; set; }

    public string? Email { get; set; }

    public string? FileName { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<LojBondedWarehouse> LojBondedWarehouses { get; set; } = new List<LojBondedWarehouse>();

    public virtual ICollection<LojContainer> LojContainers { get; set; } = new List<LojContainer>();

    public virtual ICollection<LojPortCall> LojPortCalls { get; set; } = new List<LojPortCall>();

    public virtual ICollection<LojRoutePort> LojRoutePorts { get; set; } = new List<LojRoutePort>();

    public virtual ICollection<LojShipment> LojShipmentDestinationPorts { get; set; } = new List<LojShipment>();

    public virtual ICollection<LojShipment> LojShipmentOriginPorts { get; set; } = new List<LojShipment>();

    public virtual ICollection<LojShippingRoute> LojShippingRouteDestinationPorts { get; set; } = new List<LojShippingRoute>();

    public virtual ICollection<LojShippingRoute> LojShippingRouteOriginPorts { get; set; } = new List<LojShippingRoute>();
}
