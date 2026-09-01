using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPartnerContact
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public string ContactName { get; set; } = null!;

    public string? JobTitle { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual GnlPartner Partner { get; set; } = null!;
}
