using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlProductSupplier
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? ProductId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
