using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqPickerDetail
{
    public int Id { get; set; }

    public int? PickerId { get; set; }

    public int? StoreId { get; set; }

    public int? StockId { get; set; }

    public string? InOut { get; set; }

    public decimal? Qty { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RefNo { get; set; }

    public decimal? Fqty { get; set; }

    public string? Traceability { get; set; }

    public string? StockName { get; set; }

    public decimal? RecieptQty { get; set; }

    public Guid RefId { get; set; }

    public int? PurchaseOrderRefId { get; set; }

    public string? StockName2 { get; set; }
}
