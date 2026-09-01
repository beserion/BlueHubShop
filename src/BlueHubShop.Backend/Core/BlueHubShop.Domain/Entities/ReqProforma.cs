using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqProforma
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public string? CustomerStatus { get; set; }

    public int? CompanyIdFirst { get; set; }

    public int? CompanyId { get; set; }

    public int? GroupPartnerId { get; set; }

    public int? PartnerId { get; set; }

    public int? ShippingId { get; set; }

    public string? Cocompany { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? HesapCode { get; set; }

    public string? LocalCode { get; set; }

    public string? ProformaCode { get; set; }

    public DateTime? ProformaDate { get; set; }

    public string? DocumentNumber { get; set; }

    public string? VesselName { get; set; }

    public string? InvoiceNo { get; set; }

    public int? InvoiceType { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Purpose { get; set; }

    public string? TrackingNo { get; set; }

    public string? PartnerRefNo { get; set; }

    public string? PartnerComment { get; set; }

    public decimal? PaymentTerms { get; set; }

    public decimal? ShipmentTerms { get; set; }

    public string? ShipmentTag { get; set; }

    public string? Transportation { get; set; }

    public string? BillingAddress { get; set; }

    public string? ShippingAddress { get; set; }

    public string? PreparedBy { get; set; }

    public string? AccountManager { get; set; }

    public string? MiddleMan { get; set; }

    public string? OpenOrders { get; set; }

    public string? Description { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dscamount { get; set; }

    public decimal? Netamount { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? Ttlamount { get; set; }

    public decimal? Paid { get; set; }

    public decimal? Balance { get; set; }

    public decimal? TotalBalance { get; set; }

    public decimal? TotalVolume { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? FreightCharge { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? BankDetails { get; set; }

    public string? TermsConditions { get; set; }

    public string? Service { get; set; }

    public string? Remark { get; set; }

    public string? RefId { get; set; }

    public string? RefType { get; set; }

    public string? RefUser { get; set; }

    public string? SendType { get; set; }

    public string? Side { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public bool? IsMerged { get; set; }

    public string? MergedDocumentNumber { get; set; }

    public bool IsCanceled { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryRemark { get; set; }

    public string? PickerStatus { get; set; }

    public string? PickerRemarks { get; set; }

    public string? Submitter { get; set; }

    public string? ReceivedBy { get; set; }

    public string? AccountCodeOld { get; set; }
}
