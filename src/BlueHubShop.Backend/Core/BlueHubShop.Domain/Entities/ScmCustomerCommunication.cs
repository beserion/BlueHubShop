using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ScmCustomerCommunication
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public string CommunicationType { get; set; } = null!;

    public DateTime CommunicationDate { get; set; }

    public string? Notes { get; set; }

    public string RecordedBy { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
