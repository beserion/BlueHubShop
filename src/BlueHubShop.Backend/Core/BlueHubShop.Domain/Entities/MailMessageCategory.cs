using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MailMessageCategory
{
    public int MessageId { get; set; }

    public int CategoryId { get; set; }

    public virtual MailCategory Category { get; set; } = null!;
}
