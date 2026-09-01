using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiProvider
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string ProviderCode { get; set; } = null!;

    public string ProviderName { get; set; } = null!;

    public string? BaseUrl { get; set; }

    public string? ApiKeyEncrypted { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<AiModel> AiModels { get; set; } = new List<AiModel>();
}
