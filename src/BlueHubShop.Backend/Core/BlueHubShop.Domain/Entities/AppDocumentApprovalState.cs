using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AppDocumentApprovalState
{
    public int Id { get; set; }

    public string ModuleCode { get; set; } = null!;

    public int DocumentId { get; set; }

    public int? ApprovalMatrixId { get; set; }

    public int CurrentSequence { get; set; }

    public string Status { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual AppApprovalMatrix? ApprovalMatrix { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
