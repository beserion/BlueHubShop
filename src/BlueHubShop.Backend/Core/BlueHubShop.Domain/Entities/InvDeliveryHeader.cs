using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvDeliveryHeader
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string DeliveryNo { get; set; } = null!;

    public DateTime DeliveryDate { get; set; }

    public int DeliveryType { get; set; }

    public int Status { get; set; }

    public int PartnerId { get; set; }

    public int? WarehouseId { get; set; }

    public string? DocNo { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public string Currency { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal TotalAmountTl { get; set; }

    public int? InvoiceId { get; set; }

    public int? VoucherId { get; set; }

    public int? ProjectId { get; set; }

    public string? RfqNo { get; set; }

    public string? ProjectNo { get; set; }

    public virtual ICollection<InvDeliveryLine> InvDeliveryLines { get; set; } = new List<InvDeliveryLine>();
}
