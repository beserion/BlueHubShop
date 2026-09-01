using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmNotification
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Icon { get; set; }

    public string? ActionUrl { get; set; }

    public bool IsRead { get; set; }

    public DateTime? ReadDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
