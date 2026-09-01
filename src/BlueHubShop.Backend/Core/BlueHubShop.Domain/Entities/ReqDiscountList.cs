using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqDiscountList
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Discount { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
