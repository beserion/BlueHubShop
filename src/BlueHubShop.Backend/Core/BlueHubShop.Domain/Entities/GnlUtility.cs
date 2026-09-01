using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlUtility
{
    public int Id { get; set; }

    public string Class { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }
}
