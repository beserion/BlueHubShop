using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OprToDo
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int? VesselId { get; set; }

    public string? Imo { get; set; }

    public string? PortCode { get; set; }

    public DateOnly? EtaDate { get; set; }

    public string? EtaText { get; set; }

    public string Title { get; set; } = null!;

    public string? Note { get; set; }

    public string Status { get; set; } = null!;

    public string? Priority { get; set; }

    public string? AssignedTo { get; set; }

    public DateTime? ReminderDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
