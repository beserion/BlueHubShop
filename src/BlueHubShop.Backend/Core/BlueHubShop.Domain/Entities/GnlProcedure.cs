using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlProcedure
{
    public int Id { get; set; }

    public string ProcedureName { get; set; } = null!;

    public string ScriptText { get; set; } = null!;

    public string? Description { get; set; }

    public bool Active { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? CompanyId { get; set; }

    public string? Category { get; set; }
}
