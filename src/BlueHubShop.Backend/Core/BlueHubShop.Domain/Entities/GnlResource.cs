using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlResource
{
    public int Id { get; set; }

    public string Lang { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? CreatedOn { get; set; }
}
