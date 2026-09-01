using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCurrency
{
    public int? Id { get; set; }

    public int? VesselId { get; set; }

    public int? ProgramId { get; set; }

    public int TransferStatus { get; set; }

    public string? Currency { get; set; }

    public string? Description { get; set; }

    public string? Symbol { get; set; }
}
