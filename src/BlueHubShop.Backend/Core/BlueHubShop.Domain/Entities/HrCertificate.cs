using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrCertificate
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public string CertificateName { get; set; } = null!;

    public string? CertificateNo { get; set; }

    public string? IssuingAuthority { get; set; }

    public DateOnly IssueDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? DocumentPath { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;
}
