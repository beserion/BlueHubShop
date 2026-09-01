using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinAccountMapping
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ModuleType { get; set; }

    public int DocumentType { get; set; }

    public string? ModuleName { get; set; }

    public string? DocumentName { get; set; }

    public string? AraccountCode { get; set; }

    public string? ApaccountCode { get; set; }

    public string? RevenueAccountCode { get; set; }

    public string? ExpenseAccountCode { get; set; }

    public string? VatSalesAccountCode { get; set; }

    public string? VatPurchaseAccountCode { get; set; }

    public string? InventoryAccountCode { get; set; }

    public string? CashAccountCode { get; set; }

    public string? BankAccountCode { get; set; }

    public string? GrniaccountCode { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
