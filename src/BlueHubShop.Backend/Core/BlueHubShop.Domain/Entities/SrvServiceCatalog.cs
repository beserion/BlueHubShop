using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SrvServiceCatalog
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int? ServiceCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? Unit { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? EstimatedDurationHours { get; set; }

    public int? SlatemplateId { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual SrvServiceCategory? ServiceCategory { get; set; }

    public virtual SrvSlatemplate? Slatemplate { get; set; }

    public virtual ICollection<SrvServiceRequest> SrvServiceRequests { get; set; } = new List<SrvServiceRequest>();
}
