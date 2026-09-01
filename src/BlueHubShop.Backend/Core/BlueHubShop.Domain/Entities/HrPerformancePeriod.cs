using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrPerformancePeriod
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string PeriodName { get; set; } = null!;

    public int Year { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int Status { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrPerformance> HrPerformances { get; set; } = new List<HrPerformance>();
}
