using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojShipmentCost
{
    public int Id { get; set; }

    public int ShipmentId { get; set; }

    public string? CostType { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? AmountInBaseCurrency { get; set; }

    public int? VendorId { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LojShipment Shipment { get; set; } = null!;
}
