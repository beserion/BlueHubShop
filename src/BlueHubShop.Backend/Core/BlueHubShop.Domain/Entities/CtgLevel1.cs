using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class CtgLevel1
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? DisplayOrder { get; set; }

    public string? Tkey { get; set; }

    public string? Module { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
