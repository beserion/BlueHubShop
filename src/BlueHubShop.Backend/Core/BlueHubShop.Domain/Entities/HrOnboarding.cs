using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrOnboarding
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int OfferId { get; set; }

    public int CandidateId { get; set; }

    public int? EmployeeId { get; set; }

    public string OnboardingCode { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public int Status { get; set; }

    public int? OnboardingManagerId { get; set; }

    public string? OnboardingManagerName { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual HrCandidate Candidate { get; set; } = null!;

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrOnboardingChecklist> HrOnboardingChecklists { get; set; } = new List<HrOnboardingChecklist>();

    public virtual ICollection<HrOnboardingTask> HrOnboardingTasks { get; set; } = new List<HrOnboardingTask>();

    public virtual HrOffer Offer { get; set; } = null!;
}
