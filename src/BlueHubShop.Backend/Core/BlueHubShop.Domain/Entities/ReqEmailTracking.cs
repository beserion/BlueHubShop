using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqEmailTracking
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? RfqNumber { get; set; }

    public string? Requester { get; set; }

    public string? VesselName { get; set; }

    public DateOnly? Eta { get; set; }

    public string? Receiver { get; set; }

    public string? FileStatus { get; set; }

    public string? Description { get; set; }

    public string? ItemCount { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
