using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class SrvServiceVisit
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? VisitNo { get; set; }

    public int? ServiceRequestId { get; set; }

    public int? PartnerId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? AssignedTo { get; set; }

    public DateTime? PlannedDate { get; set; }

    public DateTime? CompletedDate { get; set; }

    public string? ResultNote { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
