using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqRequestDetail
{
    public int Id { get; set; }

    public int? PartnerId { get; set; }

    public int? RequestId { get; set; }

    public int? StoreId { get; set; }

    public int? StockId { get; set; }

    public string? Catalogue { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? StockCode { get; set; }

    public string? StockName { get; set; }

    public string? Description { get; set; }

    public string? SupplierNote { get; set; }

    public string? VesselRemark { get; set; }

    public decimal? Qty { get; set; }

    public string? Unit { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Currency { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? PurchaseCurrency { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Rqty { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dsc { get; set; }

    public decimal? Dscamount { get; set; }

    public decimal? Netamount { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? Ttlamount { get; set; }

    public decimal? FreightCharge { get; set; }

    public decimal? TotalVolume { get; set; }

    public decimal? TotalWeight { get; set; }

    public string? Image { get; set; }

    public string? Remark { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Status { get; set; }

    public int? CompanyId { get; set; }

    public string? Photo { get; set; }

    public decimal? SalePrice { get; set; }

    public string? SaleCurrency { get; set; }

    public int? DisplayOrder { get; set; }

    public string? SupplierGroupName { get; set; }

    public int? ServiceAreaId { get; set; }
}
