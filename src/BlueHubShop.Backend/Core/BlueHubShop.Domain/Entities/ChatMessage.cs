using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ChatMessage
{
    public int Id { get; set; }

    public string? SenderUserId { get; set; }

    public string? TargetUserId { get; set; }

    public int? TargetGroupId { get; set; }

    public string? MessageText { get; set; }

    public string MessageType { get; set; } = null!;

    public int? ReplyToMessageId { get; set; }

    public bool IsEdited { get; set; }

    public DateTime SentAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<ChatMessageAttachment> ChatMessageAttachments { get; set; } = new List<ChatMessageAttachment>();

    public virtual ICollection<ChatMessageStatus> ChatMessageStatuses { get; set; } = new List<ChatMessageStatus>();

    public virtual ChatGroup? TargetGroup { get; set; }
}
