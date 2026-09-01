using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCounter
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? BranchId { get; set; }

    public int? CountNo { get; set; }

    public string? RefNo { get; set; }

    public string? CounterName { get; set; }

    public string? HeadPrefix { get; set; }

    public int? RefLenght { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
