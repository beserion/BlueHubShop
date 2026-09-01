using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrDiscipline
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly IncidentDate { get; set; }

    public int DisciplineType { get; set; }

    public string Description { get; set; } = null!;

    public int Action { get; set; }

    public DateOnly ActionDate { get; set; }

    public int? IssuedById { get; set; }

    public string? DocumentPath { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? EmployeeResponse { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;
}
