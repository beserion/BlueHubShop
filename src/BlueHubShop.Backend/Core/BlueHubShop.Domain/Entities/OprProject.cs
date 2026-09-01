using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OprProject
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? OfferId { get; set; }

    public int? OrderId { get; set; }

    public string ProjectNo { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal? PlannedBudget { get; set; }

    public int? CurrencyId { get; set; }

    public string Status { get; set; } = null!;

    public decimal? ProgressPercent { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? ServiceLocation { get; set; }

    public string? CountryCode { get; set; }

    public int CurrentStepOrder { get; set; }

    public int? WorkflowTemplateId { get; set; }

    public int ApprovalStatus { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<FinInvoice> FinInvoices { get; set; } = new List<FinInvoice>();

    public virtual ICollection<FinVoucher> FinVouchers { get; set; } = new List<FinVoucher>();

    public virtual ICollection<InvGoodsIssue> InvGoodsIssues { get; set; } = new List<InvGoodsIssue>();

    public virtual ICollection<InvGoodsReceipt> InvGoodsReceipts { get; set; } = new List<InvGoodsReceipt>();

    public virtual ICollection<InvStockMovement> InvStockMovements { get; set; } = new List<InvStockMovement>();

    public virtual ICollection<OprProjectBudget> OprProjectBudgets { get; set; } = new List<OprProjectBudget>();

    public virtual ICollection<OprProjectDeliverable> OprProjectDeliverables { get; set; } = new List<OprProjectDeliverable>();

    public virtual ICollection<OprProjectPhase> OprProjectPhases { get; set; } = new List<OprProjectPhase>();

    public virtual ICollection<OprProjectTeamMember> OprProjectTeamMembers { get; set; } = new List<OprProjectTeamMember>();

    public virtual GnlWorkflowTemplate? WorkflowTemplate { get; set; }
}
