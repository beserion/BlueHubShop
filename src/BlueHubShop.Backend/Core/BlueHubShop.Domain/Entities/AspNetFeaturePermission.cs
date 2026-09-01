using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AspNetFeaturePermission
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int FeatureId { get; set; }

    public bool IsGranted { get; set; }

    public decimal? DecimalValue { get; set; }

    public int? IntValue { get; set; }

    public string? StringValue { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public string? RoleId { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual AspNetFeature Feature { get; set; } = null!;
}
