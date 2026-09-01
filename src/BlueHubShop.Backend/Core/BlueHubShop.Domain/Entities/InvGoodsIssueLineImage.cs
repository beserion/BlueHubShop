using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvGoodsIssueLineImage
{
    public int Id { get; set; }

    public int GoodsIssueLineId { get; set; }

    public string? FileName { get; set; }

    public int CompanyId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual InvGoodsIssueLine GoodsIssueLine { get; set; } = null!;
}
