using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmTechnicianSkill
{
    public int Id { get; set; }

    public int TechnicianId { get; set; }

    public string SkillName { get; set; } = null!;

    public string SkillLevel { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
