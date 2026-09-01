using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MailTracking
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int MessageId { get; set; }

    public string RecipientEmail { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime EventDateTime { get; set; }

    public string? Ipaddress { get; set; }

    public string? UserAgent { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
