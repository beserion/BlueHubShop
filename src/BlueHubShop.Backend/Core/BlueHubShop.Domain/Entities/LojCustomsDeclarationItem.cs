using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojCustomsDeclarationItem
{
    public int Id { get; set; }

    public int DeclarationId { get; set; }

    public int LineNo { get; set; }

    public string? Hscode { get; set; }

    public string? Description { get; set; }

    public string? CountryOfOrigin { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalValue { get; set; }

    public decimal? DutyRate { get; set; }

    public decimal? DutyAmount { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LojCustomsDeclaration Declaration { get; set; } = null!;
}
