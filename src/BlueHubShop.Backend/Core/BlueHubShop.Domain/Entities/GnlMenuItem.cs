using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlMenuItem
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public bool OpenInNewWindow { get; set; }
}
