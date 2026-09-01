using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCity
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string CountryCode { get; set; } = null!;

    public string? CountryName { get; set; }

    public string? CityCode { get; set; }

    public string? CityName { get; set; }

    public string? AreaCode { get; set; }

    public string? DeclaredCode { get; set; }

    public decimal Lat { get; set; }

    public decimal Lng { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
