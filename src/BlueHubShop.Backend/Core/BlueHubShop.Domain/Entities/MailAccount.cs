using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class MailAccount
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string AccountName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string? TenantId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public string? AccessToken { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? TokenExpiresAt { get; set; }

    public bool IsSharedMailbox { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<MailFolder> MailFolders { get; set; } = new List<MailFolder>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();
}
