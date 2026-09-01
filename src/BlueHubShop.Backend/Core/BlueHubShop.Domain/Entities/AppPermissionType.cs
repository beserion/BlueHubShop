using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppPermissionType
{
    public int Id { get; set; }

    public int PermissionCode { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AppClaim> AppClaims { get; set; } = new List<AppClaim>();

    public virtual GnlCompany? Company { get; set; }
}
