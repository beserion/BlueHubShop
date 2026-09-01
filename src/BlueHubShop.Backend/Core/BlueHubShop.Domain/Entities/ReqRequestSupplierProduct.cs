using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqRequestSupplierProduct
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? RequestId { get; set; }

    public int? PartnerId { get; set; }

    public int? RequestDetailId { get; set; }

    public int? StockId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dsc { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Unit { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Currency { get; set; }

    public decimal? SupplierPrice { get; set; }

    public string? SupplierCurrency { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? DiscountRate { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? NetPrice { get; set; }

    public decimal? ProfitRate { get; set; }

    public string? DeliveryTime { get; set; }

    public string? DeliveryPlace { get; set; }

    public string? PaymentTerms { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? Status { get; set; }

    public string? SupplierNote { get; set; }

    public string? VesselRemark { get; set; }

    public string? InternalNote { get; set; }

    public bool? IsDeleted { get; set; }

    public decimal? Kdvrate { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? RequestType { get; set; }

    public bool? CanGivePrice { get; set; }

    public bool? IsLock { get; set; }

    public bool? IsMailSent { get; set; }

    public decimal? RequestItemsQty { get; set; }

    public decimal? PricedItemsQty { get; set; }

    public string? AccessToken { get; set; }

    public int? MailCount { get; set; }

    public string? SupplierAttach { get; set; }

    public bool? IsSelectedForQuote { get; set; }

    public decimal? FinalPrice { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }
}
