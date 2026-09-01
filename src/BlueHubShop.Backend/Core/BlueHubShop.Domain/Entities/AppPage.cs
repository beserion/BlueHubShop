using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppPage
{
    public int Id { get; set; }

    public int ModuleId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? DisplayName { get; set; }

    public string? Description { get; set; }

    public string? Route { get; set; }

    public string? Controller { get; set; }

    public string? Icon { get; set; }

    public int SortOrder { get; set; }

    public bool Active { get; set; }

    public bool IsSystem { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AppClaim> AppClaims { get; set; } = new List<AppClaim>();

    public virtual GnlCompany? Company { get; set; }

    public virtual AppModule Module { get; set; } = null!;
}
