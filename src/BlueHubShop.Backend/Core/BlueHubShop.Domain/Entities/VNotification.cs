using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VNotification
{
    public int NotificationId { get; set; }

    public string? Title { get; set; }

    public string? Message { get; set; }

    public string? Url { get; set; }

    public string? FromUserName { get; set; }

    public string? ToUserName { get; set; }

    public string ToUserId { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? ReadDate { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsPrivate { get; set; }
}
