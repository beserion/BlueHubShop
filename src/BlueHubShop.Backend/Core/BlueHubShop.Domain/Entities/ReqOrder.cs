using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqOrder
{
    public int Id { get; set; }

    public int? OfferId { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public string? PartnerName { get; set; }

    public string? VesselName { get; set; }

    public string? OrderStatus { get; set; }

    public string? PurchaseOrderStatus { get; set; }

    public string? CustomerRefNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? RfqNo { get; set; }

    public string? OrderNo { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? DeliveryLocation { get; set; }

    public int? OutputWarehouseId { get; set; }

    public string? OutputStoreName { get; set; }

    public string? DeliveryTime { get; set; }

    public string? PaymentPlan { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public bool? InCustomArea { get; set; }

    public string? InvoiceNo { get; set; }

    public string? DocumentNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? PortFee { get; set; }

    public decimal? CustomFee { get; set; }

    public decimal? Transportation { get; set; }

    public string? DeliveryType { get; set; }

    public string? DeliveryPeriod { get; set; }

    public string? Note { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Dscamount { get; set; }

    public decimal? Netamount { get; set; }

    public decimal? Kdvamount { get; set; }

    public decimal? Ttlamount { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? StatusId { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public int ApprovalStatus { get; set; }
}
