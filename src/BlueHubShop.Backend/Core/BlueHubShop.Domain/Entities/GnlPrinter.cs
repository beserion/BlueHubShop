using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPrinter
{
    public int Id { get; set; }

    public string? PrinterName { get; set; }

    public string? IpAddress { get; set; }

    public int Port { get; set; }

    public string? Location { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
