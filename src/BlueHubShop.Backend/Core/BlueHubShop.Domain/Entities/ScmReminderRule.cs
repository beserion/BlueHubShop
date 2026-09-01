using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmReminderRule
{
    public int Id { get; set; }

    public string RuleName { get; set; } = null!;

    public string TargetType { get; set; } = null!;

    public int DaysBefore { get; set; }

    public int DaysAfter { get; set; }

    public string NotificationChannel { get; set; } = null!;

    public int? TemplateId { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
