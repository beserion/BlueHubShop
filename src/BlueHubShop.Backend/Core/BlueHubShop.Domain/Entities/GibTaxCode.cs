using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GibTaxCode
{
    public int Id { get; set; }

    public string? CodeType { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public decimal? Rate { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
