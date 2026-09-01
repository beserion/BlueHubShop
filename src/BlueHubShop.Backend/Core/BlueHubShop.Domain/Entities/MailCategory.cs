using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MailCategory
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? ColorCode { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<MailMessageCategory> MailMessageCategories { get; set; } = new List<MailMessageCategory>();
}
