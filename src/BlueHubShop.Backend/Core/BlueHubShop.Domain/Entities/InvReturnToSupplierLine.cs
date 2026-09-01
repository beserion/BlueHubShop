using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvReturnToSupplierLine
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ReturnToSupplierId { get; set; }

    public int StockId { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNo { get; set; }

    public decimal ReturnQty { get; set; }

    public string? Unit { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Amount { get; set; }

    public string? Reason { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual InvReturnsToSupplier ReturnToSupplier { get; set; } = null!;
}
