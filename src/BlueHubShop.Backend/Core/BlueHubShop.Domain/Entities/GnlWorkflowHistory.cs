using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlWorkflowHistory
{
    public int Id { get; set; }

    public int RecordId { get; set; }

    public string? ActionType { get; set; }

    public string? OldStatus { get; set; }

    public string? NewStatus { get; set; }

    public string? Reason { get; set; }

    public string? ActionBy { get; set; }

    public DateTime ActionDate { get; set; }

    public int? CompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string ModuleName { get; set; } = null!;
}
