using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlSayac
{
    public int Id { get; set; }

    public string? SayacAdi { get; set; }

    public string? RefNo { get; set; }

    public string? BasEk { get; set; }

    public int? Basamak { get; set; }

    public int? SayacNo { get; set; }

    public int? RefYear { get; set; }
}
