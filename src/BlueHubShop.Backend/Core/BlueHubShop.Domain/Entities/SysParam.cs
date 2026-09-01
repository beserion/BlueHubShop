using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SysParam
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? ValueType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
