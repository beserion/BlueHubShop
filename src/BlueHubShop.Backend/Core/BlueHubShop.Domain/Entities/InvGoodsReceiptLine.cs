using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvGoodsReceiptLine
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int GoodsReceiptId { get; set; }

    public int StockId { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNo { get; set; }

    public decimal OrderedQty { get; set; }

    public decimal ReceivedQty { get; set; }

    public decimal RejectedQty { get; set; }

    public string? Unit { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Amount { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public decimal? LandedCostAmount { get; set; }

    public decimal? TotalCost { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvGoodsReceipt GoodsReceipt { get; set; } = null!;

    public virtual ICollection<InvGoodsReceiptLineImage> InvGoodsReceiptLineImages { get; set; } = new List<InvGoodsReceiptLineImage>();

    public virtual ICollection<InvLandedCostDistribution> InvLandedCostDistributions { get; set; } = new List<InvLandedCostDistribution>();
}
