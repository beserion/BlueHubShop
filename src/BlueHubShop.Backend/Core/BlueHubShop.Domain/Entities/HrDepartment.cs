using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrDepartment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string DepartmentCode { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public int? ParentDepartmentId { get; set; }

    public int? ManagerId { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public int SortOrder { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrJobPosting> HrJobPostings { get; set; } = new List<HrJobPosting>();

    public virtual ICollection<HrOffer> HrOffers { get; set; } = new List<HrOffer>();

    public virtual ICollection<HrPosition> HrPositions { get; set; } = new List<HrPosition>();

    public virtual ICollection<HrDepartment> InverseParentDepartment { get; set; } = new List<HrDepartment>();

    public virtual HrDepartment? ParentDepartment { get; set; }
}
