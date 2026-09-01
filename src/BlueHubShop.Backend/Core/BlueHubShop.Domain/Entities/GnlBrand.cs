using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlBrand
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public bool? Active { get; set; }

    public string? Category { get; set; }

    public string? BrandCode { get; set; }

    public string? BrandName { get; set; }

    public string? ServiceArea { get; set; }

    public string? Logo { get; set; }

    public string? Country { get; set; }

    public string? Origin { get; set; }

    public string? Photo { get; set; }

    public string? ServisArea { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
