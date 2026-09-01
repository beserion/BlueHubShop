using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VInvoiceAll
{
    public string InvoiceOrigin { get; set; } = null!;

    public int Id { get; set; }

    public int? InvoiceType { get; set; }

    public string? SendType { get; set; }

    public string? VesselName { get; set; }

    public string? Side { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public string? PartnerRefNo { get; set; }

    public string? PartnerComment { get; set; }

    public string? Status { get; set; }

    public string? InvoiceCode { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? DocumentNumber { get; set; }

    public string? PreparedBy { get; set; }

    public string? AccountManager { get; set; }

    public string? Description { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public double? PaymentTerms { get; set; }

    public double? ShipmentTerms { get; set; }

    public string? ShipmentTag { get; set; }

    public string? Currency { get; set; }

    public double? Rate { get; set; }

    public double? Amount { get; set; }

    public double? Dscamount { get; set; }

    public double? Netamount { get; set; }

    public double? Kdvamount { get; set; }

    public double? Ttlamount { get; set; }

    public double? Paid { get; set; }

    public double? Balance { get; set; }

    public double? TotalBalance { get; set; }

    public string? Transportation { get; set; }

    public string? BillingAddress { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Remark { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
