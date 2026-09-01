using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VResource
{
    public string Name { get; set; } = null!;

    public string? Tr { get; set; }

    public string? En { get; set; }

    public string? Ge { get; set; }
}
