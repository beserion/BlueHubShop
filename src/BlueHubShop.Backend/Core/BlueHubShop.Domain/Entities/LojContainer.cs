using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojContainer
{
    public int Id { get; set; }

    public string ContainerNo { get; set; } = null!;

    public string? ContainerType { get; set; }

    public string? ContainerSize { get; set; }

    public string? Status { get; set; }

    public int? OwnerId { get; set; }

    public bool? IsOwned { get; set; }

    public string? CurrentLocation { get; set; }

    public int? CurrentPortId { get; set; }

    public int? CurrentWarehouseId { get; set; }

    public decimal? TareWeight { get; set; }

    public decimal? MaxPayload { get; set; }

    public decimal? MaxGrossWeight { get; set; }

    public decimal? InternalVolume { get; set; }

    public bool? IsReefer { get; set; }

    public decimal? SetTemperature { get; set; }

    public decimal? CurrentTemperature { get; set; }

    public string? Condition { get; set; }

    public DateOnly? LastInspectionDate { get; set; }

    public DateOnly? NextInspectionDate { get; set; }

    public string? DamageDescription { get; set; }

    public bool? Active { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlPort? CurrentPort { get; set; }

    public virtual ICollection<LojShipmentContainer> LojShipmentContainers { get; set; } = new List<LojShipmentContainer>();
}
