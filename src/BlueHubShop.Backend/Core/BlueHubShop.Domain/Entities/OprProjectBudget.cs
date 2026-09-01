using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OprProjectBudget
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ProjectId { get; set; }

    public int? ProjectPhaseId { get; set; }

    public string LineType { get; set; } = null!;

    public decimal Amount { get; set; }

    public int? CurrencyId { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual OprProject Project { get; set; } = null!;

    public virtual OprProjectPhase? ProjectPhase { get; set; }
}
