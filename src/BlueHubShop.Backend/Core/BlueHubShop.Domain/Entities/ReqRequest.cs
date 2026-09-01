using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqRequest
{
    public int Id { get; set; }

    public int? PartnerId { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public string? RequestNo { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? RefType { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Currency { get; set; }

    public decimal? Ttlamount { get; set; }

    public string? MakerType { get; set; }

    public string? ResponsiblePerson { get; set; }

    public string? DocumentNo { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Quality { get; set; }

    public string? RequestCode { get; set; }

    public string? VesselRefNo { get; set; }

    public string? ExternalSystem { get; set; }

    public string? ExternalRfqId { get; set; }

    public string? IntegrationStatus { get; set; }

    public string? IntegrationMessage { get; set; }

    public DateTime? LastSyncDate { get; set; }

    public string? AccountName { get; set; }

    public string? DeliveryPort { get; set; }

    public string? RfqNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? ImportedExcelPath { get; set; }

    public virtual ICollection<ReqRequestItem> ReqRequestItems { get; set; } = new List<ReqRequestItem>();
}
