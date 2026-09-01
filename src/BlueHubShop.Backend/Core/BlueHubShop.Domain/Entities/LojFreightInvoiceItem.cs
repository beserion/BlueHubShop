using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojFreightInvoiceItem
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public int LineNo { get; set; }

    public string? ChargeType { get; set; }

    public string? Description { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<LojFreightInvoiceItem> InverseInvoice { get; set; } = new List<LojFreightInvoiceItem>();

    public virtual LojFreightInvoiceItem Invoice { get; set; } = null!;
}
