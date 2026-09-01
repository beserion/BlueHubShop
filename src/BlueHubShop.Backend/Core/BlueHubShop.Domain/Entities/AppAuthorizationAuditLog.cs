using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppAuthorizationAuditLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Action { get; set; }

    public string? EntityType { get; set; }

    public string? EntityId { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public string? RequestPath { get; set; }

    public bool Success { get; set; }

    public string? ErrorMessage { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
