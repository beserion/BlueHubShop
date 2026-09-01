using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinCustomCurrency
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public bool Active { get; set; }
}
