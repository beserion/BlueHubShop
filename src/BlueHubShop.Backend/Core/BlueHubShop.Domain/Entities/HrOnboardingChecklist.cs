using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrOnboardingChecklist
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int OnboardingId { get; set; }

    public string ItemName { get; set; } = null!;

    public int ItemType { get; set; }

    public bool IsRequired { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int? CompletedById { get; set; }

    public string? CompletedByName { get; set; }

    public string? Notes { get; set; }

    public string? DocumentPath { get; set; }

    public int SortOrder { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrOnboarding Onboarding { get; set; } = null!;
}
