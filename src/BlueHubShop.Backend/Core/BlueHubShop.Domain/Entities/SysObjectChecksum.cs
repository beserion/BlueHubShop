using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SysObjectChecksum
{
    public string? Db { get; set; }

    public string? Parent { get; set; }

    public string? Object { get; set; }

    public int? Checksum { get; set; }

    public string? Def1 { get; set; }

    public string Def2 { get; set; } = null!;

    public string? Definition { get; set; }

    public string? Type { get; set; }

    public string? TypeDesc { get; set; }

    public DateTime CreatedOn { get; set; }
}
