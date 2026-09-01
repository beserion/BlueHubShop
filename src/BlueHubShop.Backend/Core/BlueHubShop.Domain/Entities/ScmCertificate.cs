using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmCertificate
{
    public int Id { get; set; }

    public string CertificateNo { get; set; } = null!;

    public int CertificateTypeId { get; set; }

    public int PartnerId { get; set; }

    public int? CustomerSiteId { get; set; }

    public int AssetId { get; set; }

    public int? ServiceJobId { get; set; }

    public int? InspectionId { get; set; }

    public int? CalibrationId { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ExpiryDate { get; set; }

    public int ValidityPeriodMonths { get; set; }

    public string? IssuedBy { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string Status { get; set; } = null!;

    public string? RenewalStatus { get; set; }

    public string VerificationCode { get; set; } = null!;

    public string? Notes { get; set; }

    public int? PreviousCertificateId { get; set; }

    public int? NextCertificateId { get; set; }

    public int Version { get; set; }

    public bool IsLatest { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
