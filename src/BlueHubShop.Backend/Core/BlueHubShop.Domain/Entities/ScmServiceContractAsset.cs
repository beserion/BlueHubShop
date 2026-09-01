using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmServiceContractAsset
{
    public int Id { get; set; }

    public int ContractId { get; set; }

    public int AssetId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
