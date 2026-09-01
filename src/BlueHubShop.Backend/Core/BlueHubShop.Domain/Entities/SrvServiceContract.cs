using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SrvServiceContract
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? ContractNo { get; set; }

    public int PartnerId { get; set; }

    public string? Title { get; set; }

    public string? Scope { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal? ContractValue { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<SrvServiceRequest> SrvServiceRequests { get; set; } = new List<SrvServiceRequest>();
}
