using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MsgNotificationUser
{
    public int Id { get; set; }

    public int NotificationId { get; set; }

    public string FromUserId { get; set; } = null!;

    public string ToUserId { get; set; } = null!;

    public string? ToGroupId { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsPrivate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ReadDate { get; set; }
}
