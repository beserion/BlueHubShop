using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrPerformance
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public int PeriodId { get; set; }

    public int? EvaluatorId { get; set; }

    public decimal? GoalAchievement { get; set; }

    public decimal? JobKnowledge { get; set; }

    public decimal? Quality { get; set; }

    public decimal? Productivity { get; set; }

    public decimal? Communication { get; set; }

    public decimal? Teamwork { get; set; }

    public decimal? Initiative { get; set; }

    public decimal? Attendance { get; set; }

    public decimal? OverallScore { get; set; }

    public int Rating { get; set; }

    public string? Strengths { get; set; }

    public string? AreasToImprove { get; set; }

    public string? Goals { get; set; }

    public string? EmployeeComments { get; set; }

    public string? ManagerComments { get; set; }

    public int Status { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual HrPerformancePeriod Period { get; set; } = null!;
}
