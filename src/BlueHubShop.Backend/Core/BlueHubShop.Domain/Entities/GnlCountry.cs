using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCountry
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryNameEn { get; set; }

    public string? CountryName { get; set; }

    public string? Description { get; set; }

    public string? Flag { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? PhoneCode { get; set; }

    public string? Currency { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
