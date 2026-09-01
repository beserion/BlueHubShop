using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojBondedWarehouse
{
    public int Id { get; set; }

    public string WarehouseCode { get; set; } = null!;

    public string WarehouseName { get; set; } = null!;

    public string? WarehouseType { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public int? PortId { get; set; }

    public string? LicenseNo { get; set; }

    public DateOnly? LicenseExpiryDate { get; set; }

    public decimal? TotalCapacity { get; set; }

    public decimal? UsedCapacity { get; set; }

    public string? ContactPerson { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool? Active { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlPort? Port { get; set; }
}
