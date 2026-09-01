using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqOfferDetail
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? OfferId { get; set; }

    public int? RequestDetailId { get; set; }

    public int? OrderNo { get; set; }

    public int? ProductId { get; set; }

    public int? StockId { get; set; }

    public string? Unit { get; set; }

    public decimal? Qty { get; set; }

    public string? Status { get; set; }

    public string? Currency { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? SupplierNote { get; set; }

    public string? VesselRemark { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Price { get; set; }

    public decimal? PrchPrice { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dsc { get; set; }

    public decimal? Dscamount { get; set; }

    public decimal? Netamount { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? Ttlamount { get; set; }

    public string? Image { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
