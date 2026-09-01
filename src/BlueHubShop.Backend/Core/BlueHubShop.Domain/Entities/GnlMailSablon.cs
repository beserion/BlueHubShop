using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlMailSablon
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? Language { get; set; }

    public string? Template { get; set; }

    public string? Contents { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
