using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlEmailAccount
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? Category { get; set; }

    public string? Profile { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public string? Pop3Address { get; set; }

    public string? SmtpAddress { get; set; }

    public int? Pop3Port { get; set; }

    public int? SmtpPort { get; set; }

    public bool? Ssl { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
