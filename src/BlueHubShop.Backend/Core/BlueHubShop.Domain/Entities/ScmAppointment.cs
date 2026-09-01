using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmAppointment
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? PartnerId { get; set; }

    public int? AssetId { get; set; }

    public int? TechnicianId { get; set; }

    public string Status { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ScmAsset? Asset { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual GnlPartner? Partner { get; set; }

    public virtual HrEmployee? Technician { get; set; }
}
