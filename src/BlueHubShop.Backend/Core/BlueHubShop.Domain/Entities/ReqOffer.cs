using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqOffer
{
    public int Id { get; set; }

    public int? RequestId { get; set; }

    public string? Status { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public string? OfferCode { get; set; }

    public string? DocumentNo { get; set; }

    public string? PreparedBy { get; set; }

    public DateTime? OfferDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? PartnerRefNo { get; set; }

    public string? Currency { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dscamount { get; set; }

    public decimal? Netamount { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? Ttlamount { get; set; }

    public decimal? Balance { get; set; }

    public decimal? TotalBalance { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public decimal? FreightCharge { get; set; }

    public bool? ServiceLinked { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? Discount { get; set; }

    public decimal? PaymentTerms { get; set; }

    public string? DeliveryLocation { get; set; }

    public string? Remark { get; set; }

    public int? ValidityDays { get; set; }

    public string? DeliveryType { get; set; }

    public string? VesselName { get; set; }

    public int? CustomFee { get; set; }

    public bool? MessageReceived { get; set; }

    public int? PortFee { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public decimal? ApprovedAmount { get; set; }

    public decimal? SystemAmount { get; set; }

    public int? StatusId { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public int ApprovalStatus { get; set; }

    public string? RfqNo { get; set; }

    public string? ProjectNo { get; set; }

    public virtual ICollection<OfferApprovalToken> OfferApprovalTokens { get; set; } = new List<OfferApprovalToken>();
}
