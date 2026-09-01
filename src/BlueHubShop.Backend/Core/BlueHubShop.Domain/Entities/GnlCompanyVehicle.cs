using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCompanyVehicle
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string PlateNo { get; set; } = null!;

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public string Status { get; set; } = null!;

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? OwnerName { get; set; }
}
