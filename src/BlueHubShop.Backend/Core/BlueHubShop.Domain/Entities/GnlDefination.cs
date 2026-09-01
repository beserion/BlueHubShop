using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlDefination
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public int? DefOrder { get; set; }

    public string? DefGroup { get; set; }

    public string? DefKey { get; set; }

    public string? DefText { get; set; }

    public string? DefValue { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Icon { get; set; }
}
