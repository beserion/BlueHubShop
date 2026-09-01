using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojShipmentContainer
{
    public int Id { get; set; }

    public int ShipmentId { get; set; }

    public int ContainerId { get; set; }

    public string? SealNo { get; set; }

    public decimal? GrossWeight { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LojContainer Container { get; set; } = null!;

    public virtual LojShipment Shipment { get; set; } = null!;
}
