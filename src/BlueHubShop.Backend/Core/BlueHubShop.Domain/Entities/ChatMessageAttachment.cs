using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ChatMessageAttachment
{
    public int Id { get; set; }

    public int MessageId { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public long FileSize { get; set; }

    public string? ContentType { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ChatMessage Message { get; set; } = null!;
}
