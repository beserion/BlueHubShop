using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AspNetFeature
{
    public int Id { get; set; }

    public string? Module { get; set; }

    public string? FeatureKey { get; set; }

    public string? DisplayName { get; set; }

    public int ValueType { get; set; }

    public string? Description { get; set; }

    public int OrderNo { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AspNetFeaturePermission> AspNetFeaturePermissions { get; set; } = new List<AspNetFeaturePermission>();

    public virtual GnlCompany? Company { get; set; }
}
