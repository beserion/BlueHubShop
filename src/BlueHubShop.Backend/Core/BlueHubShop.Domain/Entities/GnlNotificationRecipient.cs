using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlNotificationRecipient
{
    public int Id { get; set; }

    public int NotificationId { get; set; }

    public string UserId { get; set; } = null!;

    public bool IsRead { get; set; }

    public DateTime? ReadDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int CompanyId { get; set; }

    public virtual GnlNotification Notification { get; set; } = null!;
}
