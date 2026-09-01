using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlNotification
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Message { get; set; }

    public string Type { get; set; } = null!;

    public string? Icon { get; set; }

    public string? TargetType { get; set; }

    public string? TargetId { get; set; }

    public string? LinkUrl { get; set; }

    public bool IsRead { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int CompanyId { get; set; }

    public virtual ICollection<GnlNotificationRecipient> GnlNotificationRecipients { get; set; } = new List<GnlNotificationRecipient>();
}
