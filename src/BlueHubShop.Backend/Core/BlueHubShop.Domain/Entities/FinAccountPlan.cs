using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinAccountPlan
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? ParentCode { get; set; }

    public string? RefCode { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? AccountType { get; set; }

    public int? Level { get; set; }

    public bool? IsGroup { get; set; }

    public decimal? Balance { get; set; }

    public string? InitialBalanceType { get; set; }

    public DateTime? InitialBalanceDate { get; set; }

    public decimal? InitialBalance { get; set; }

    public decimal? InitialBalanceTl { get; set; }

    public decimal? Budget { get; set; }

    public decimal? BalanceTl { get; set; }

    public decimal? BalanceEur { get; set; }

    public decimal? BalanceUsd { get; set; }

    public int? TransactionCount { get; set; }

    public bool? Hide { get; set; }

    public bool? Active { get; set; }

    public bool? IsSelectable { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public decimal? Kdv { get; set; }
}
