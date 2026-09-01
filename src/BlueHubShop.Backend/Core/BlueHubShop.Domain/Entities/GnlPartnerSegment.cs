using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPartnerSegment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string SegmentCode { get; set; } = null!;

    public string SegmentName { get; set; } = null!;

    public string? Description { get; set; }

    public string Color { get; set; } = null!;

    public string? Icon { get; set; }

    public int SortOrder { get; set; }

    public bool IsActive { get; set; }

    public string? CriteriaJson { get; set; }

    public bool AutoAssign { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<GnlPartnerSegmentAssignment> GnlPartnerSegmentAssignments { get; set; } = new List<GnlPartnerSegmentAssignment>();
}
