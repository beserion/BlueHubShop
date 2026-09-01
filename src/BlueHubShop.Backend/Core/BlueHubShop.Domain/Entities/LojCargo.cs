using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojCargo
{
    public int Id { get; set; }

    public string CargoNo { get; set; } = null!;

    public string? CargoDescription { get; set; }

    public string? CargoType { get; set; }

    public string? Status { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? NetWeight { get; set; }

    public string? WeightUnit { get; set; }

    public decimal? Volume { get; set; }

    public string? VolumeUnit { get; set; }

    public int? PackageCount { get; set; }

    public string? PackageType { get; set; }

    public bool? IsHazardous { get; set; }

    public string? Imoclass { get; set; }

    public string? Unnumber { get; set; }

    public string? HazardousDescription { get; set; }

    public bool? RequiresTemperatureControl { get; set; }

    public decimal? MinTemperature { get; set; }

    public decimal? MaxTemperature { get; set; }

    public int? CustomerId { get; set; }

    public string? Hscode { get; set; }

    public decimal? DeclaredValue { get; set; }

    public string? Currency { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<LojShipmentCargo> LojShipmentCargos { get; set; } = new List<LojShipmentCargo>();
}
