using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrInterview
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int ApplicationId { get; set; }

    public int CandidateId { get; set; }

    public int InterviewType { get; set; }

    public int Status { get; set; }

    public DateTime ScheduledDate { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? ActualEndDate { get; set; }

    public string? Location { get; set; }

    public string? MeetingLink { get; set; }

    public string? InterviewerIds { get; set; }

    public string? InterviewerNames { get; set; }

    public int? OverallRating { get; set; }

    public string? TechnicalSkills { get; set; }

    public string? CommunicationSkills { get; set; }

    public string? CulturalFit { get; set; }

    public string? Strengths { get; set; }

    public string? Weaknesses { get; set; }

    public string? InterviewNotes { get; set; }

    public bool IsRecommended { get; set; }

    public string? NextStep { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual HrApplication Application { get; set; } = null!;

    public virtual HrCandidate Candidate { get; set; } = null!;

    public virtual GnlCompany Company { get; set; } = null!;
}
