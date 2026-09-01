using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class IntShipServIncomingRfq
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? ShipServRfqid { get; set; }

    public string Rfqno { get; set; } = null!;

    public DateTime? Rfqdate { get; set; }

    public string? RequestNumber { get; set; }

    public DateTime? QuoteBefore { get; set; }

    public string? BuyerCompany { get; set; }

    public string? BuyerContact { get; set; }

    public string? BuyerPhone { get; set; }

    public string? SupplierName { get; set; }

    public string? SupplierContact { get; set; }

    public string? SupplierPhone { get; set; }

    public string? VesselName { get; set; }

    public string? Imo { get; set; }

    public DateTime? VesselEta { get; set; }

    public DateTime? VesselEtd { get; set; }

    public string? ShipYard { get; set; }

    public string? HullNo { get; set; }

    public string? DeliveryPort { get; set; }

    public string? CaseCategory { get; set; }

    public string Status { get; set; } = null!;

    public string? RawJson { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
