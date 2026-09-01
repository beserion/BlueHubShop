using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojBillsOfLading
{
    public int Id { get; set; }

    public string Blno { get; set; } = null!;

    public DateOnly Bldate { get; set; }

    public string? Bltype { get; set; }

    public string? Status { get; set; }

    public int? ShipmentId { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? NotifyParty { get; set; }

    public string? VesselName { get; set; }

    public string? VoyageNo { get; set; }

    public string? PortOfLoading { get; set; }

    public string? PortOfDischarge { get; set; }

    public string? PlaceOfReceipt { get; set; }

    public string? PlaceOfDelivery { get; set; }

    public string? GoodsDescription { get; set; }

    public int? PackageCount { get; set; }

    public string? PackageType { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? Volume { get; set; }

    public string? FreightTerms { get; set; }

    public string? PaymentTerms { get; set; }

    public int? OriginalCount { get; set; }

    public DateOnly? OnBoardDate { get; set; }

    public string? ShippingMarks { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LojShipment? Shipment { get; set; }
}
