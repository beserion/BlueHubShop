using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class IntShipServDocument
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int LocalDocumentId { get; set; }

    public string? LocalDocumentNo { get; set; }

    public string? ShipServDocumentId { get; set; }

    public string DocumentType { get; set; } = null!;

    public string Direction { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ErrorMessage { get; set; }

    public string? SentBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
