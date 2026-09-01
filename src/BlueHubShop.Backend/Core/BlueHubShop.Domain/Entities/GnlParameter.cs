using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlParameter
{
    public int Id { get; set; }

    public int? VesselId { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public string? ValueType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
