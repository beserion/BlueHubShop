using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrApplication
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int CandidateId { get; set; }

    public int JobPostingId { get; set; }

    public DateTime ApplicationDate { get; set; }

    public int Status { get; set; }

    public string? CoverLetter { get; set; }

    public string? ExpectedSalary { get; set; }

    public DateOnly? AvailableStartDate { get; set; }

    public int? Rating { get; set; }

    public string? EvaluationNotes { get; set; }

    public int? ReviewedById { get; set; }

    public DateTime? ReviewedDate { get; set; }

    public string? RejectionReason { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual HrCandidate Candidate { get; set; } = null!;

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrInterview> HrInterviews { get; set; } = new List<HrInterview>();

    public virtual ICollection<HrOffer> HrOffers { get; set; } = new List<HrOffer>();

    public virtual HrJobPosting JobPosting { get; set; } = null!;
}
