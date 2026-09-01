using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmServiceContract
{
    public int Id { get; set; }

    public string ContractNo { get; set; } = null!;

    public int PartnerId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? ContractType { get; set; }

    public string? ServiceScope { get; set; }

    public int ServiceFrequencyMonths { get; set; }

    public int SlaResponseTimeHours { get; set; }

    public int IncludedVisits { get; set; }

    public decimal Price { get; set; }

    public string Currency { get; set; } = null!;

    public string? RenewalType { get; set; }

    public bool AutoRenewal { get; set; }

    public string Status { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
