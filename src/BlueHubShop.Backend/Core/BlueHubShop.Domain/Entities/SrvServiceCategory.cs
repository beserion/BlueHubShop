using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SrvServiceCategory
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Code { get; set; }

    public int SortOrder { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<SrvServiceCatalog> SrvServiceCatalogs { get; set; } = new List<SrvServiceCatalog>();
}
