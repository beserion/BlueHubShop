using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ChatMessageStatus
{
    public int Id { get; set; }

    public int MessageId { get; set; }

    public string UserId { get; set; } = null!;

    public bool IsDelivered { get; set; }

    public DateTime? DeliveredAt { get; set; }

    public bool IsRead { get; set; }

    public DateTime? ReadAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ChatMessage Message { get; set; } = null!;
}
