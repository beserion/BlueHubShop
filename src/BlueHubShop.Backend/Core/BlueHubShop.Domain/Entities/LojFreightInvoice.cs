using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojFreightInvoice
{
    public int Id { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public DateOnly InvoiceDate { get; set; }

    public string? InvoiceType { get; set; }

    public string? Status { get; set; }

    public int? ShipmentId { get; set; }

    public int? CustomerId { get; set; }

    public int? VendorId { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Currency { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? PaidDate { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LojShipment? Shipment { get; set; }
}
