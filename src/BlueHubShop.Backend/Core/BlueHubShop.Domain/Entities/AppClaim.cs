using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppClaim
{
    public int Id { get; set; }

    public string ClaimValue { get; set; } = null!;

    public int? ModuleId { get; set; }

    public int? PageId { get; set; }

    public int? PermissionTypeId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public bool IsSystem { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AppApprovalMatrixStep> AppApprovalMatrixSteps { get; set; } = new List<AppApprovalMatrixStep>();

    public virtual ICollection<AppRoleClaim> AppRoleClaims { get; set; } = new List<AppRoleClaim>();

    public virtual ICollection<AppTemporaryPermission> AppTemporaryPermissions { get; set; } = new List<AppTemporaryPermission>();

    public virtual ICollection<AppUserClaim> AppUserClaims { get; set; } = new List<AppUserClaim>();

    public virtual GnlCompany? Company { get; set; }

    public virtual AppModule? Module { get; set; }

    public virtual AppPage? Page { get; set; }

    public virtual AppPermissionType? PermissionType { get; set; }
}
