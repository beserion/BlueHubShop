using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrPosition
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string PositionCode { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public int Level { get; set; }

    public string? Description { get; set; }

    public string? Requirements { get; set; }

    public decimal? MinSalary { get; set; }

    public decimal? MaxSalary { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrJobPosting> HrJobPostings { get; set; } = new List<HrJobPosting>();

    public virtual ICollection<HrOffer> HrOffers { get; set; } = new List<HrOffer>();
}
