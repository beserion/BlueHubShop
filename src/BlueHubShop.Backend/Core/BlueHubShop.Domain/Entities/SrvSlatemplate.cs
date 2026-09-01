using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SrvSlatemplate
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string? PriorityLevel { get; set; }

    public int ResponseTimeMinutes { get; set; }

    public int ResolutionTimeHours { get; set; }

    public bool IsDefault { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<SrvServiceCatalog> SrvServiceCatalogs { get; set; } = new List<SrvServiceCatalog>();
}
