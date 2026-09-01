using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlProductSupplierPrice
{
    public int Id { get; set; }

    public int StockId { get; set; }

    public int PartnerId { get; set; }

    public decimal LastPrice { get; set; }

    public string? Currency { get; set; }

    public DateTime? PriceDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public int? ReferenceRequestId { get; set; }
}
