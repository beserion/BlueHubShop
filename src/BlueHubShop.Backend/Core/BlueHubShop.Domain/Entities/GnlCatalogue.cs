using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCatalogue
{
    public int Id { get; set; }

    public int? ImageId { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public string? CatalogueName { get; set; }

    public bool? CatalogueSystem { get; set; }

    public bool? Visible { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
