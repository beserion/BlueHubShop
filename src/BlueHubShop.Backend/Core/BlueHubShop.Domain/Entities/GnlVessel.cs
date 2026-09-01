using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlVessel
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public int? CompanyId { get; set; }

    public int? PoolId { get; set; }

    public int? PartnerId { get; set; }

    public string? RefCode { get; set; }

    public string? OwnerName { get; set; }

    public string? MiddleMan { get; set; }

    public string? VesselCode { get; set; }

    public string? VesselName { get; set; }

    public string? VesselSize { get; set; }

    public string? VesselType { get; set; }

    public string? ImoNo { get; set; }

    public string? DockYard { get; set; }

    public string? BuildYard { get; set; }

    public string? HullNumber { get; set; }

    public string? Description { get; set; }

    public string? Email { get; set; }

    public string? Flag { get; set; }

    public string? CallSign { get; set; }

    public string? PortOfRegister { get; set; }

    public string? OfficialNumber { get; set; }

    public string? InternationalNumber { get; set; }

    public string? Class { get; set; }

    public string? DeadWeight { get; set; }

    public string? GrossTonnage { get; set; }

    public string? BuildDate { get; set; }

    public string? VesselPhoto { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<InvVesselWarehouse> InvVesselWarehouses { get; set; } = new List<InvVesselWarehouse>();

    public virtual ICollection<LojPortCall> LojPortCalls { get; set; } = new List<LojPortCall>();

    public virtual ICollection<LojShipment> LojShipments { get; set; } = new List<LojShipment>();

    public virtual ICollection<LojVesselFuelConsumption> LojVesselFuelConsumptions { get; set; } = new List<LojVesselFuelConsumption>();
}
