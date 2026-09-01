using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlProductPrice
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int StockId { get; set; }

    public string? Title { get; set; }

    public string? Currency { get; set; }

    public decimal Price { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;
}
