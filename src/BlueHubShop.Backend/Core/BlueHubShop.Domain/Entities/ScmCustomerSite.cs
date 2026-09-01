using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmCustomerSite
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public string SiteName { get; set; } = null!;

    public string? Address { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
