using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlModule
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? ModuleName { get; set; }

    public int? OrderNo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? VesselId { get; set; }
}
