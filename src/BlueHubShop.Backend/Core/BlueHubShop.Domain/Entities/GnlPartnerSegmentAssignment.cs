using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPartnerSegmentAssignment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int PartnerId { get; set; }

    public int SegmentId { get; set; }

    public DateTime AssignedDate { get; set; }

    public string AssignedBy { get; set; } = null!;

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual GnlPartnerSegment Segment { get; set; } = null!;
}
