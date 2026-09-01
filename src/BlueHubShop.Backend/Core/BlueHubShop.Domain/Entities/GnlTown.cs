using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlTown
{
    public int Id { get; set; }

    public string? CountryCode { get; set; }

    public string? CityCode { get; set; }

    public string? TownCode { get; set; }

    public string? TownName { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
