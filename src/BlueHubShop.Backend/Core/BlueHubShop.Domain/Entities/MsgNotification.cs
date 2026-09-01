using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MsgNotification
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Message { get; set; }

    public string? Url { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? DocumentNumber { get; set; }

    public string? Origin { get; set; }
}
