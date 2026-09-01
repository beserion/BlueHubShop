using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojSupplierPerformance
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int? QualityScore { get; set; }

    public int? DeliveryScore { get; set; }

    public int? PriceScore { get; set; }

    public int? ResponseScore { get; set; }

    public int? OverallScore { get; set; }

    public int? TotalOrders { get; set; }

    public int? OnTimeDeliveries { get; set; }

    public int? LateDeliveries { get; set; }

    public int? QualityIssues { get; set; }

    public decimal? TotalPurchaseValue { get; set; }

    public string? Currency { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
