using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class DocFile
{
    public long Id { get; set; }

    public int CompanyId { get; set; }

    public string FileName { get; set; } = null!;

    public string? OriginalName { get; set; }

    public string? ContentType { get; set; }

    public long FileSize { get; set; }

    public byte StorageType { get; set; }

    public string? StoragePath { get; set; }

    public string? FileHash { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    public virtual ICollection<DocFileLink> DocFileLinks { get; set; } = new List<DocFileLink>();
}
