using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvAnnualCountLine
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int AnnualCountId { get; set; }

    public int StockId { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNo { get; set; }

    public decimal SystemQty { get; set; }

    public decimal CountedQty { get; set; }

    public decimal VarianceQty { get; set; }

    public string? Unit { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal VarianceAmount { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual InvAnnualCount AnnualCount { get; set; } = null!;

    public virtual GnlCompany Company { get; set; } = null!;
}
