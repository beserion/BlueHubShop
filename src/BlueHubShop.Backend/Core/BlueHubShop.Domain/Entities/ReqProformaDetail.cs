using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqProformaDetail
{
    public int Id { get; set; }

    public int? ProformaId { get; set; }

    public int? CompanyId { get; set; }

    public int? StoreId { get; set; }

    public int? StockId { get; set; }

    public string? SupplierCode { get; set; }

    public string? Grup { get; set; }

    public string? Catalogue { get; set; }

    public string? StockCode { get; set; }

    public string? StockName { get; set; }

    public string? StockName2 { get; set; }

    public string? Description { get; set; }

    public string? Unit { get; set; }

    public string? Currency { get; set; }

    public decimal? Locprice { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Price { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dsc { get; set; }

    public decimal? Dscamount { get; set; }

    public decimal? Netamount { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? Ttlamount { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public decimal? FreightCharge { get; set; }

    public string? Image { get; set; }

    public string? Remark { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Status { get; set; }

    public string? PickerStatus { get; set; }

    public decimal? Fqty { get; set; }

    public string? DrawingNo { get; set; }

    public string? PartNo { get; set; }

    public string? ItemNo { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public decimal? PrchPrice { get; set; }

    public int OrderNo { get; set; }

    public decimal? Mdsc { get; set; }
}
