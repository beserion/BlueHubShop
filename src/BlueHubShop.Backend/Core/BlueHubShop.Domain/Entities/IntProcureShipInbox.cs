using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class IntProcureShipInbox
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string DocumentType { get; set; } = null!;

    public string ExternalId { get; set; } = null!;

    public string Payload { get; set; } = null!;

    public bool IsProcessed { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public string? ErrorMessage { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
