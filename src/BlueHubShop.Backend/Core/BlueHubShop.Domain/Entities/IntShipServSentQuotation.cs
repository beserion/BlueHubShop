using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class IntShipServSentQuotation
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string QuotationNo { get; set; } = null!;

    public string Rfqno { get; set; } = null!;

    public string? BuyerCompany { get; set; }

    public string? BuyerContact { get; set; }

    public string? BuyerPhone { get; set; }

    public string? VesselName { get; set; }

    public string? Imo { get; set; }

    public string? DeliveryPort { get; set; }

    public string? CaseCategory { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? QuoteDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string? Currency { get; set; }

    public string? Status { get; set; }

    public string? ShipServStatus { get; set; }

    public int? Rfqid { get; set; }
}
