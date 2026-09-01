using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SrvServiceRequest
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? TicketNo { get; set; }

    public int? PartnerId { get; set; }

    public int? ServiceCatalogId { get; set; }

    public int? SlatemplateId { get; set; }

    public string Subject { get; set; } = null!;

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? Priority { get; set; }

    public string? AssignedTo { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? ResponseDate { get; set; }

    public DateTime? ResolutionDate { get; set; }

    public int? ServiceContractId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual SrvServiceCatalog? ServiceCatalog { get; set; }

    public virtual SrvServiceContract? ServiceContract { get; set; }
}
