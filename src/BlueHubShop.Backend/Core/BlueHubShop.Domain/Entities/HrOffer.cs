using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrOffer
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ApplicationId { get; set; }

    public int CandidateId { get; set; }

    public int JobPostingId { get; set; }

    public string OfferCode { get; set; } = null!;

    public DateTime OfferDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int Status { get; set; }

    public int? DepartmentId { get; set; }

    public int? PositionId { get; set; }

    public int EmploymentType { get; set; }

    public DateOnly? ProposedStartDate { get; set; }

    public decimal? BaseSalary { get; set; }

    public string? Benefits { get; set; }

    public string? OfferDetails { get; set; }

    public DateTime? CandidateResponseDate { get; set; }

    public bool? CandidateAccepted { get; set; }

    public string? CandidateResponseNotes { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual HrApplication Application { get; set; } = null!;

    public virtual HrCandidate Candidate { get; set; } = null!;

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrOnboarding> HrOnboardings { get; set; } = new List<HrOnboarding>();

    public virtual HrJobPosting JobPosting { get; set; } = null!;

    public virtual HrPosition? Position { get; set; }
}
