using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlWorkflowTemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string? ModuleName { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual ICollection<GnlWorkflowStep> GnlWorkflowSteps { get; set; } = new List<GnlWorkflowStep>();

    public virtual ICollection<OprProject> OprProjects { get; set; } = new List<OprProject>();
}
