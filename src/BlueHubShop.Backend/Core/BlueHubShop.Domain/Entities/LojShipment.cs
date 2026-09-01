using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojShipment
{
    public int Id { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public DateOnly ShipmentDate { get; set; }

    public string? ShipmentType { get; set; }

    public string? Status { get; set; }

    public bool? IsUrgent { get; set; }

    public int? OriginPortId { get; set; }

    public string? OriginAddress { get; set; }

    public int? DestinationPortId { get; set; }

    public string? DestinationAddress { get; set; }

    public int? VesselId { get; set; }

    public int? RouteId { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Atd { get; set; }

    public DateTime? Ata { get; set; }

    public int? CustomerId { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public decimal? FreightCost { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Currency { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedByUserId { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlPort? DestinationPort { get; set; }

    public virtual ICollection<LojBillsOfLading> LojBillsOfLadings { get; set; } = new List<LojBillsOfLading>();

    public virtual ICollection<LojCustomsDeclaration> LojCustomsDeclarations { get; set; } = new List<LojCustomsDeclaration>();

    public virtual ICollection<LojFreightInvoice> LojFreightInvoices { get; set; } = new List<LojFreightInvoice>();

    public virtual ICollection<LojShipmentCargo> LojShipmentCargos { get; set; } = new List<LojShipmentCargo>();

    public virtual ICollection<LojShipmentContainer> LojShipmentContainers { get; set; } = new List<LojShipmentContainer>();

    public virtual ICollection<LojShipmentCost> LojShipmentCosts { get; set; } = new List<LojShipmentCost>();

    public virtual ICollection<LojShipmentDocument> LojShipmentDocuments { get; set; } = new List<LojShipmentDocument>();

    public virtual ICollection<LojVoyageProfitability> LojVoyageProfitabilities { get; set; } = new List<LojVoyageProfitability>();

    public virtual GnlPort? OriginPort { get; set; }

    public virtual LojShippingRoute? Route { get; set; }

    public virtual GnlVessel? Vessel { get; set; }
}
