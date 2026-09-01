using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OprVesselVisit
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public string? Imo { get; set; }

    public string? CompanyName { get; set; }

    public string? PortCode { get; set; }

    public DateTime? VisitDate { get; set; }

    public string? VisitorName { get; set; }

    public string? SalesNote { get; set; }

    public string? FieldSalesNote { get; set; }

    public bool IsVisited { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
