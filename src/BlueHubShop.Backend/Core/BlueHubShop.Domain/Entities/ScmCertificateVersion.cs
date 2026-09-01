using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmCertificateVersion
{
    public int Id { get; set; }

    public int CertificateId { get; set; }

    public int Version { get; set; }

    public int RevisionNo { get; set; }

    public DateTime RevisionDate { get; set; }

    public string ChangedBy { get; set; } = null!;

    public string? ChangeReason { get; set; }

    public string? DocumentFileName { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
