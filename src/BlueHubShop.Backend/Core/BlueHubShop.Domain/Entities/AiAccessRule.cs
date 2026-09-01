using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiAccessRule
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public int? AgentId { get; set; }

    public bool AllowUse { get; set; }

    public bool AllowSensitiveData { get; set; }

    public int? DailyTokenLimit { get; set; }

    public int? MonthlyTokenLimit { get; set; }

    public bool RequireApproval { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
