using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlWorkflowDelegation
{
    public int Id { get; set; }

    public string? DelegatorUserId { get; set; }

    public string? DelegateeUserId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }

    public string? Reason { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
