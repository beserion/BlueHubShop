using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCategory
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? VesselId { get; set; }

    public int? ParentId { get; set; }

    public int? CatalogueId { get; set; }

    public int? CategoryNo { get; set; }

    public string? CategoryName { get; set; }

    public int? ImageId { get; set; }

    public int? OrderNo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
