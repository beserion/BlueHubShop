using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrCandidate
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string CandidateCode { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? TckimlikNo { get; set; }

    public string? PassportNo { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? BirthPlace { get; set; }

    public int Gender { get; set; }

    public int MaritalStatus { get; set; }

    public string? Nationality { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public int EducationLevel { get; set; }

    public string? University { get; set; }

    public string? EducationDepartment { get; set; }

    public int? GraduationYear { get; set; }

    public string? ExperienceSummary { get; set; }

    public int? YearsOfExperience { get; set; }

    public string? Cvpath { get; set; }

    public string? PhotoPath { get; set; }

    public string? PortfolioUrl { get; set; }

    public string? LinkedInUrl { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public string? Source { get; set; }

    public string? ReferredBy { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrApplication> HrApplications { get; set; } = new List<HrApplication>();

    public virtual ICollection<HrInterview> HrInterviews { get; set; } = new List<HrInterview>();

    public virtual ICollection<HrOffer> HrOffers { get; set; } = new List<HrOffer>();

    public virtual ICollection<HrOnboarding> HrOnboardings { get; set; } = new List<HrOnboarding>();
}
