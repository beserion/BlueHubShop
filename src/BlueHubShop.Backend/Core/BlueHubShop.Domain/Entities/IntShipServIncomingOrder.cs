using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class IntShipServIncomingOrder
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string Pono { get; set; } = null!;

    public string QuotationNo { get; set; } = null!;

    public string? VesselName { get; set; }

    public string? Imo { get; set; }

    public string? DeliveryPort { get; set; }

    public string? CaseCategory { get; set; }

    public string? BuyerCompany { get; set; }

    public string? BuyerContact { get; set; }

    public string? BuyerPhone { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string? Currency { get; set; }

    public string? Status { get; set; }

    public string? ShipServStatus { get; set; }
}
