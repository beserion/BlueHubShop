using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojVoyageProfitability
{
    public int Id { get; set; }

    public int ShipmentId { get; set; }

    public decimal? Revenue { get; set; }

    public decimal? FreightCost { get; set; }

    public decimal? PortCost { get; set; }

    public decimal? CustomsCost { get; set; }

    public decimal? WarehouseCost { get; set; }

    public decimal? InsuranceCost { get; set; }

    public decimal? OtherCost { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? GrossProfit { get; set; }

    public decimal? ProfitMargin { get; set; }

    public string? Currency { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LojShipment Shipment { get; set; } = null!;
}
