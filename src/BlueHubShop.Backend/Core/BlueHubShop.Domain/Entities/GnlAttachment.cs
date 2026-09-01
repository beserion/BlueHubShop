using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlAttachment
{
    public int Id { get; set; }

    public string? RefCode { get; set; }

    public string? Title { get; set; }

    public string? FileName { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public long? RefId { get; set; }

    public long? RefParentId { get; set; }

    public string? Module { get; set; }

    public int? CompanyId { get; set; }

    public string? RefName { get; set; }
}
