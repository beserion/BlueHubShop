using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlAddress
{
    public int Id { get; set; }

    public string? RefCode { get; set; }

    public int? PartnerId { get; set; }

    public string? ShortName { get; set; }

    public string? Description { get; set; }

    public string? AddressType { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Pk { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
