using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class VCatchError
{
    public int? ErrNum { get; set; }

    public int? ErrSev { get; set; }

    public int? ErrState { get; set; }

    public string? ErrProc { get; set; }

    public int? ErrLine { get; set; }

    public string? ErrMsg { get; set; }

    public string FullErrMsg { get; set; } = null!;
}
