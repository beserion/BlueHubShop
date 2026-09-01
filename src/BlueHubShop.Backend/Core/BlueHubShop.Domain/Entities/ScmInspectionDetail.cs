using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmInspectionDetail
{
    public int Id { get; set; }

    public int InspectionId { get; set; }

    public string Parameter { get; set; } = null!;

    public string Result { get; set; } = null!;

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
