using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmAsset
{
    public int Id { get; set; }

    public string AssetCode { get; set; } = null!;

    public int PartnerId { get; set; }

    public int? CustomerSiteId { get; set; }

    public int AssetCategoryId { get; set; }

    public int AssetTypeId { get; set; }

    public string? Manufacturer { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? ManufacturingDate { get; set; }

    public DateTime? InstallationDate { get; set; }

    public string? Location { get; set; }

    public string? Department { get; set; }

    public string Criticality { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string QrToken { get; set; } = null!;

    public string? Notes { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual ICollection<ScmAppointment> ScmAppointments { get; set; } = new List<ScmAppointment>();
}
