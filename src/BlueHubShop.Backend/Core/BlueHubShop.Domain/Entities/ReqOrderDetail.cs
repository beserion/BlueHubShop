using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqOrderDetail
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? OfferDetailId { get; set; }

    public int? RowNo { get; set; }

    public int? WarehouseId { get; set; }

    public string? StoreName { get; set; }

    public int? StockId { get; set; }

    public string? StockCode { get; set; }

    public string? StockName { get; set; }

    public string? StockName2 { get; set; }

    public decimal? Qty { get; set; }

    public string? Unit { get; set; }

    public decimal? Price { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dsc { get; set; }

    public decimal? Dscamount { get; set; }

    public decimal? Netamount { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? Ttlamount { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? Currency { get; set; }

    public string? Gtipcode { get; set; }

    public string? TurkishDescription { get; set; }

    public string? Remark { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public int? ProductId { get; set; }

    public string? SupplierNote { get; set; }

    public string? VesselRemark { get; set; }

    public string? Description { get; set; }

    public virtual GnlStore? Warehouse { get; set; }
}
