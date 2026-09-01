using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppUserScope
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string ScopeType { get; set; } = null!;

    public int? ScopeId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
