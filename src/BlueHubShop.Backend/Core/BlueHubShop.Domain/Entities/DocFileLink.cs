using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class DocFileLink
{
    public long Id { get; set; }

    public int CompanyId { get; set; }

    public string EntityName { get; set; } = null!;

    public long EntityId { get; set; }

    public long FileId { get; set; }

    public string? Category { get; set; }

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    public virtual DocFile File { get; set; } = null!;
}
