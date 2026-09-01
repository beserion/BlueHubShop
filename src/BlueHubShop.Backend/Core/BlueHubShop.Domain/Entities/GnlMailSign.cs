using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlMailSign
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public int? CompanyId { get; set; }

    public string? UserName { get; set; }

    public string? UserMail { get; set; }

    public string? UserRank { get; set; }

    public string? UserSign { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
