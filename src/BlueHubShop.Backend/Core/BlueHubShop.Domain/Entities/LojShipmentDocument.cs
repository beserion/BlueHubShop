using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojShipmentDocument
{
    public int Id { get; set; }

    public int ShipmentId { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentNo { get; set; }

    public string? DocumentName { get; set; }

    public DateOnly? DocumentDate { get; set; }

    public string? FilePath { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LojShipment Shipment { get; set; } = null!;
}
