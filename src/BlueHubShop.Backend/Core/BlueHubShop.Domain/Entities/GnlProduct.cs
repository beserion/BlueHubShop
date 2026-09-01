using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlProduct
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? CatalogueId { get; set; }

    public int? CategoryId { get; set; }

    public int? ProductGroupId { get; set; }

    public int? ProductCategoryId { get; set; }

    public string? Category { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? ProductNameTr { get; set; }

    public string? Description { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? DrawingNo { get; set; }

    public string? PartNo { get; set; }

    public string? SpecialCode { get; set; }

    public string? Unit { get; set; }

    public string? Foto { get; set; }

    public string? SubCategory { get; set; }

    public string? Barcode { get; set; }

    public string? ItemNo { get; set; }

    public decimal? Volume { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Rating { get; set; }

    public bool? Favorite { get; set; }

    public bool? ShowOnWeb { get; set; }

    public bool? SaleActive { get; set; }

    public decimal? MinQty { get; set; }

    public bool? MinQtyControl { get; set; }

    public decimal? MaxQty { get; set; }

    public bool? MaxQtyControl { get; set; }

    public string? Remarks { get; set; }

    public bool? Active { get; set; }

    public bool? B2bactive { get; set; }

    public int? Gtip { get; set; }

    public string? Origin { get; set; }

    public bool? Xml { get; set; }

    public string? Impacode { get; set; }

    public string? Issacode { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? AccountCode { get; set; }

    public virtual GnlProductCategory? ProductCategory { get; set; }

    public virtual GnlProductGroup? ProductGroup { get; set; }
}
