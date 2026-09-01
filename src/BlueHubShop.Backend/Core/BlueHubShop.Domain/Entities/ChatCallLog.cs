using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ChatCallLog
{
    public int Id { get; set; }

    public string CallerUserId { get; set; } = null!;

    public string? ReceiverUserId { get; set; }

    public int? TargetGroupId { get; set; }

    public string CallType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime StartedAt { get; set; }

    public DateTime? EndedAt { get; set; }

    public int DurationSeconds { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
