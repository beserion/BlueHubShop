using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvStockImage
{
    public int Id { get; set; }

    public int StockId { get; set; }

    public string? FileName { get; set; }

    public int? SortOrder { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
