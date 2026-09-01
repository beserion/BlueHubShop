using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiFeedbackLog
{
    public long Id { get; set; }

    public long? ConversationId { get; set; }

    public long? MessageId { get; set; }

    public int UserId { get; set; }

    public int? Rating { get; set; }

    public string? FeedbackText { get; set; }

    public DateTime CreatedDate { get; set; }
}
