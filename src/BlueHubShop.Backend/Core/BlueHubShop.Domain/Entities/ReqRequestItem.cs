using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqRequestItem
{
    public int Id { get; set; }

    public int RequestId { get; set; }

    public int PartnerId { get; set; }

    public int StockId { get; set; }

    public string? VesselRemark { get; set; }

    public string? SupplierNote { get; set; }

    public decimal Qty { get; set; }

    public string? Unit { get; set; }

    public decimal UnitPrice { get; set; }

    public string? Currency { get; set; }

    public decimal DiscountRate { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal Kdvrate { get; set; }

    public decimal Kdvamount { get; set; }

    public decimal NetPrice { get; set; }

    public decimal TotalPrice { get; set; }

    public string? Status { get; set; }

    public virtual ReqRequest Request { get; set; } = null!;
}
