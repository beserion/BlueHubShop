using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinInvoiceLine
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? WarehouseId { get; set; }

    public int? ProductId { get; set; }

    public int? InvoiceId { get; set; }

    public string? Description { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? VatRate { get; set; }

    public decimal? DscRate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ProductCode { get; set; }

    public string? TaxExemptionCode { get; set; }

    public string? WithholdingTaxCode { get; set; }

    public decimal? WithholdingTaxRate { get; set; }
}
