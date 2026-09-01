using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmTechnicianQualification
{
    public int Id { get; set; }

    public int TechnicianId { get; set; }

    public string QualificationName { get; set; } = null!;

    public string? CertificateNo { get; set; }

    public DateTime ExpiryDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
