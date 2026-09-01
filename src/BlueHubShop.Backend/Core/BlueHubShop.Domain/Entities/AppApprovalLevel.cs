using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppApprovalLevel
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int LevelValue { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AppApprovalMatrixStep> AppApprovalMatrixSteps { get; set; } = new List<AppApprovalMatrixStep>();

    public virtual GnlCompany? Company { get; set; }
}
