using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OprProjectTeamMember
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ProjectId { get; set; }

    public string? RoleCode { get; set; }

    public string? RoleName { get; set; }

    public bool IsProjectManager { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? EmployeeId { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual OprProject Project { get; set; } = null!;
}
