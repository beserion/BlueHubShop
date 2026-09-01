using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MailMessage
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int AccountId { get; set; }

    public int? FolderId { get; set; }

    public string GraphMessageId { get; set; } = null!;

    public string? GraphThreadId { get; set; }

    public string? Subject { get; set; }

    public string? SenderName { get; set; }

    public string? SenderEmail { get; set; }

    public string? ToRecipients { get; set; }

    public string? CcRecipients { get; set; }

    public string? BccRecipients { get; set; }

    public string? BodyPreview { get; set; }

    public string? BodyContent { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public DateTime? SentDateTime { get; set; }

    public bool IsRead { get; set; }

    public bool IsDraft { get; set; }

    public bool HasAttachments { get; set; }

    public string? Importance { get; set; }

    public string? AssignedTo { get; set; }

    public string? RefModule { get; set; }

    public int? RefId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual MailAccount Account { get; set; } = null!;

    public virtual MailFolder? Folder { get; set; }
}
