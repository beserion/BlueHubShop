using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvStock
{
    public int Id { get; set; }

    public int? WarehouseId { get; set; }

    public int? ProductId { get; set; }

    public int? CompanyId { get; set; }

    public int? ShipmentId { get; set; }

    public string? DocumentNo { get; set; }

    public string? QrCode { get; set; }

    public string? Impacode { get; set; }

    public string? Issacode { get; set; }

    public string? StockCode { get; set; }

    public string? StockName { get; set; }

    public string? StockNameTr { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public decimal? Qty { get; set; }

    public string? Unit { get; set; }

    public decimal? PrchPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public decimal? Ttlamount { get; set; }

    public decimal? Kdv { get; set; }

    public string? RefCode { get; set; }

    public string? SpecialCode { get; set; }

    public string? Description { get; set; }

    public string? SerialNo { get; set; }

    public string? Grup { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? ShelfAddress { get; set; }

    public string? BoxNo { get; set; }

    public string? Barcode { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? DrawingNo { get; set; }

    public string? PartNo { get; set; }

    public string? ItemNo { get; set; }

    public decimal? Volume { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Dsc { get; set; }

    public string? Currency { get; set; }

    public decimal? Afkdvrate { get; set; }

    public decimal? Sfkdvrate { get; set; }

    public decimal? DealerSalesPrice { get; set; }

    public decimal? Bsfkdvrate { get; set; }

    public decimal? Profit { get; set; }

    public decimal? Rating { get; set; }

    public bool? Favorite { get; set; }

    public bool? ShowOnWeb { get; set; }

    public bool? CostCalculate { get; set; }

    public bool? SaleActive { get; set; }

    public bool? SerialNoActive { get; set; }

    public decimal? MinQty { get; set; }

    public bool? MinQtyControl { get; set; }

    public decimal? MaxQty { get; set; }

    public bool? MaxQtyControl { get; set; }

    public string? Foto { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? Active { get; set; }

    public bool? B2bactive { get; set; }

    public DateOnly? ExprDate { get; set; }

    public bool? ExprDateControl { get; set; }

    public int? Gtip { get; set; }

    public string? Origin { get; set; }

    public bool? Xml { get; set; }

    public string? SubCategory2 { get; set; }

    public decimal? DiscountPrstg { get; set; }

    public string? PurcahseAccountCode { get; set; }

    public string? PurcahseTaxCode { get; set; }

    public string? SalesAccountCode { get; set; }

    public string? SalesTaxCode { get; set; }

    public string? CurrencyPurchase { get; set; }

    public string? CurrencyDealer { get; set; }

    public bool? HasRecipe { get; set; }

    public string? DefaultValuationMethod { get; set; }

    public decimal? StandardCost { get; set; }
}
