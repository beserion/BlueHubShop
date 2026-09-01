using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmServiceChecklistItem
{
    public int Id { get; set; }

    public int ChecklistId { get; set; }

    public string CheckItem { get; set; } = null!;

    public string? Description { get; set; }

    public bool Required { get; set; }

    public int SortOrder { get; set; }

    public bool PhotoRequired { get; set; }

    public bool EvidenceRequired { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
