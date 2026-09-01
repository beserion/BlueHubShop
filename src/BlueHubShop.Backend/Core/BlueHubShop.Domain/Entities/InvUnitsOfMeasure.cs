using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvUnitsOfMeasure
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string UoMcode { get; set; } = null!;

    public string UoMname { get; set; } = null!;

    public string? Symbol { get; set; }

    public bool Active { get; set; }

    public int? BaseUoMid { get; set; }

    public decimal? ConversionFactor { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual InvUnitsOfMeasure? BaseUoM { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<InvUnitsOfMeasure> InverseBaseUoM { get; set; } = new List<InvUnitsOfMeasure>();
}
