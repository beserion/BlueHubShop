using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VFirstLastDayOfMonth
{
    public int Month { get; set; }

    public DateTime? First { get; set; }

    public DateTime? Last { get; set; }
}
