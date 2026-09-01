using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class TelegramMessage
{
    public int Id { get; set; }

    public string BotToken { get; set; } = null!;

    public string Group { get; set; } = null!;

    public long GroupId { get; set; }

    public long? MessageId { get; set; }

    public string Message { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? Origin { get; set; }

    public string? Response { get; set; }

    public short ErrType { get; set; }

    public string? ErrMsg { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }

    public DateTime? SentOn { get; set; }

    public int RetryCount { get; set; }

    public DateTime? DueDate { get; set; }
}
