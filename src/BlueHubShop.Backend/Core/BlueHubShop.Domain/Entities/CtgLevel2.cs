using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class CtgLevel2
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? DisplayOrder { get; set; }

    public int? Level1Id { get; set; }

    public string? Tkey { get; set; }

    public string? Module { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
