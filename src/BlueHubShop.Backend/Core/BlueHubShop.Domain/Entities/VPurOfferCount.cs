using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VPurOfferCount
{
    public int RequestId { get; set; }

    public int? SubmittedCount { get; set; }

    public int? WaitingCount { get; set; }

    public int? OfferCount { get; set; }
}
