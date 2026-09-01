using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvGoodsReceiptLineImage
{
    public int Id { get; set; }

    public int GoodsReceiptLineId { get; set; }

    public string? FileName { get; set; }

    public int CompanyId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual InvGoodsReceiptLine GoodsReceiptLine { get; set; } = null!;
}
