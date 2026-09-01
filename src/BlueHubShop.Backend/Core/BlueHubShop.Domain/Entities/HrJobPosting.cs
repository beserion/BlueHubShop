using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrJobPosting
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string JobCode { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public int? PositionId { get; set; }

    public string? JobDescription { get; set; }

    public string? Requirements { get; set; }

    public string? Responsibilities { get; set; }

    public decimal? MinSalary { get; set; }

    public decimal? MaxSalary { get; set; }

    public int EmploymentType { get; set; }

    public DateTime PostingDate { get; set; }

    public DateTime? ClosingDate { get; set; }

    public DateOnly? StartDate { get; set; }

    public int Status { get; set; }

    public bool IsPublishedOnWebsite { get; set; }

    public bool IsPublishedOnLinkedIn { get; set; }

    public bool IsPublishedOnOther { get; set; }

    public string? OtherChannels { get; set; }

    public int ViewCount { get; set; }

    public int ApplicationCount { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrApplication> HrApplications { get; set; } = new List<HrApplication>();

    public virtual ICollection<HrOffer> HrOffers { get; set; } = new List<HrOffer>();

    public virtual HrPosition? Position { get; set; }
}
