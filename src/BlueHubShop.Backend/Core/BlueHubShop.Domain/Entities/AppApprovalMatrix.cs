using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppApprovalMatrix
{
    public int Id { get; set; }

    public string ModuleCode { get; set; } = null!;

    public string? DocumentType { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? MinimumAmount { get; set; }

    public decimal? MaximumAmount { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AppApprovalMatrixStep> AppApprovalMatrixSteps { get; set; } = new List<AppApprovalMatrixStep>();

    public virtual ICollection<AppDocumentApprovalState> AppDocumentApprovalStates { get; set; } = new List<AppDocumentApprovalState>();

    public virtual GnlCompany? Company { get; set; }
}
