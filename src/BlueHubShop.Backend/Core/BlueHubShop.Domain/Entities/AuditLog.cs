using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AuditLog
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? UserName { get; set; }

    public string? TransactionCode { get; set; }

    public string? DocumentNumber { get; set; }

    public string? DocumentType { get; set; }

    public string? Action { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }
}
