using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmServiceJobActivity
{
    public int Id { get; set; }

    public int ServiceJobId { get; set; }

    public string ActivityName { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
