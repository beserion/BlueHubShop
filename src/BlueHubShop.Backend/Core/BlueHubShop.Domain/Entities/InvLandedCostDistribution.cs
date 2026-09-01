using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvLandedCostDistribution
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int LandedCostId { get; set; }

    public int GoodsReceiptLineId { get; set; }

    public decimal DistributedAmount { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvGoodsReceiptLine GoodsReceiptLine { get; set; } = null!;

    public virtual InvLandedCost LandedCost { get; set; } = null!;
}
