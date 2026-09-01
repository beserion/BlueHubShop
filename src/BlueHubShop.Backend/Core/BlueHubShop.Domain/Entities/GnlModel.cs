using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlModel
{
    public int Id { get; set; }

    public int BrandId { get; set; }

    public string ModelName { get; set; } = null!;

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
