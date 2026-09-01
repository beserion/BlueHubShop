using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojCustomsDeclaration
{
    public int Id { get; set; }

    public string DeclarationNo { get; set; } = null!;

    public DateOnly DeclarationDate { get; set; }

    public string? DeclarationType { get; set; }

    public string? Status { get; set; }

    public int? ShipmentId { get; set; }

    public int? ImporterId { get; set; }

    public int? ExporterId { get; set; }

    public int? CustomsBrokerId { get; set; }

    public string? CustomsOffice { get; set; }

    public string? EntryPort { get; set; }

    public decimal? Cifvalue { get; set; }

    public decimal? Fobvalue { get; set; }

    public decimal? FreightValue { get; set; }

    public decimal? InsuranceValue { get; set; }

    public string? Currency { get; set; }

    public decimal? CustomsDuty { get; set; }

    public decimal? Vat { get; set; }

    public decimal? OtherTaxes { get; set; }

    public decimal? TotalDuties { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<LojCustomsDeclarationItem> LojCustomsDeclarationItems { get; set; } = new List<LojCustomsDeclarationItem>();

    public virtual LojShipment? Shipment { get; set; }
}
