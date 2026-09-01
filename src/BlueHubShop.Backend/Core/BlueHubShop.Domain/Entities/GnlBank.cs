using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlBank
{
    public int Id { get; set; }

    public string BankName { get; set; } = null!;

    public string? BankCode { get; set; }

    public int? CompanyId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
