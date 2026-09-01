using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlServiceArea
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public int? CompanyId { get; set; }

    public int? SortOrder { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
