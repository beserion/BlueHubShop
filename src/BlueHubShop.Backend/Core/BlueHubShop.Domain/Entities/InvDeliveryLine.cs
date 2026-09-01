using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvDeliveryLine
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int HeaderId { get; set; }

    public int? ProductId { get; set; }

    public string? Description { get; set; }

    public decimal Qty { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal VatRate { get; set; }

    public decimal LineTotal { get; set; }

    public decimal VatTotal { get; set; }

    public decimal GnlTotal { get; set; }

    public string? Note { get; set; }

    public decimal? ReceivedQty { get; set; }

    public virtual InvDeliveryHeader Header { get; set; } = null!;
}
