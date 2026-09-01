using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MailAttachment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int MessageId { get; set; }

    public string GraphAttachmentId { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string? ContentType { get; set; }

    public long SizeInBytes { get; set; }

    public string? FilePath { get; set; }

    public bool IsInline { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
