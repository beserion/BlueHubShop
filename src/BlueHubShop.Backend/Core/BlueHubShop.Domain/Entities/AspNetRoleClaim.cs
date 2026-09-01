using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AspNetRoleClaim
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public string? RoleId { get; set; }

    public string? Module { get; set; }

    public string? Action { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
