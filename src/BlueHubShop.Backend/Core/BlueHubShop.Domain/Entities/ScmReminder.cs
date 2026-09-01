using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmReminder
{
    public int Id { get; set; }

    public int? RuleId { get; set; }

    public string TargetType { get; set; } = null!;

    public int TargetId { get; set; }

    public DateTime ReminderDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? SentDate { get; set; }

    public string? ResultMessage { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
