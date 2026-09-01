using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvLandedCost
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int GoodsReceiptId { get; set; }

    public string CostType { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Currency { get; set; }

    public decimal? CurrencyRate { get; set; }

    public string? DistributionMethod { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvGoodsReceipt GoodsReceipt { get; set; } = null!;

    public virtual ICollection<InvLandedCostDistribution> InvLandedCostDistributions { get; set; } = new List<InvLandedCostDistribution>();
}
