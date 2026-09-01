using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class IntShipServIncomingRfqline
{
    public int Id { get; set; }

    public int Rfqid { get; set; }

    public int? LineNo { get; set; }

    public string? Description { get; set; }

    public string? ItemCode { get; set; }

    public string? RefNo { get; set; }

    public string? DrawingNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? UoM { get; set; }

    public string? VesselNotes { get; set; }

    public decimal? UnitCost { get; set; }

    public decimal? DiscountRate { get; set; }

    public string? Availability { get; set; }

    public decimal? LineTotal { get; set; }
}
