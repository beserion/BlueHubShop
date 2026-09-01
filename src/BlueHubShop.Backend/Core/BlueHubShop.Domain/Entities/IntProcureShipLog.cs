using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class IntProcureShipLog
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string Direction { get; set; } = null!;

    public string DocumentType { get; set; } = null!;

    public string LocalReferenceNo { get; set; } = null!;

    public string? ExternalReferenceNo { get; set; }

    public string? Status { get; set; }

    public string? Payload { get; set; }

    public string? Response { get; set; }

    public string? ErrorMessage { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
