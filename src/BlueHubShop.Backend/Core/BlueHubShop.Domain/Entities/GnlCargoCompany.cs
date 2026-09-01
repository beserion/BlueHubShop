using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCargoCompany
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? TaxNumber { get; set; }

    public string? TrackingUrlTemplate { get; set; }

    public string? ContactPhone { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
