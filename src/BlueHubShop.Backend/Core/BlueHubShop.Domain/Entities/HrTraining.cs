using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrTraining
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string TrainingName { get; set; } = null!;

    public string? TrainingCode { get; set; }

    public int TrainingType { get; set; }

    public string? Provider { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? DurationHours { get; set; }

    public string? Location { get; set; }

    public decimal? Cost { get; set; }

    public string Currency { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsCompleted { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrEmployeeTraining> HrEmployeeTrainings { get; set; } = new List<HrEmployeeTraining>();
}
