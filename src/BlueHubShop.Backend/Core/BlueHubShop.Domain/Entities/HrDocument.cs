using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrDocument
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public string DocumentName { get; set; } = null!;

    public int DocumentType { get; set; }

    public string? FilePath { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? Description { get; set; }

    public bool IsConfidential { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;
}
