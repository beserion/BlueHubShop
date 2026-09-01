using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCertificate
{
    public int Id { get; set; }

    public int? ServiceId { get; set; }

    public int? PartnerId { get; set; }

    public int? VesselId { get; set; }

    public string? DocumentNo { get; set; }

    public string? CertificateNo { get; set; }

    public string? Category { get; set; }

    public string? CertificateName { get; set; }

    public string? Description { get; set; }

    public string? IssuedBy { get; set; }

    public DateTime? IssuedDate { get; set; }

    public DateTime? ValidDate { get; set; }

    public string? Photo { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? TempFileName { get; set; }
}
