using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiConversationMessage
{
    public long Id { get; set; }

    public long ConversationId { get; set; }

    public string MessageRole { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public int? TokenCount { get; set; }

    public int? ModelId { get; set; }

    public int? ResponseTimeMs { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }
}
