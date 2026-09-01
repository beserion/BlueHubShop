using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppTemporaryPermission
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int ClaimId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Reason { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual AppClaim Claim { get; set; } = null!;

    public virtual GnlCompany? Company { get; set; }
}
