using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPartnerServiceArea
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? StockId { get; set; }

    public int? ServiceAreaId { get; set; }

    public string? GroupCode { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
