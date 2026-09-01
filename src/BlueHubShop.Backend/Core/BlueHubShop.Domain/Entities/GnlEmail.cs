using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlEmail
{
    public int Id { get; set; }

    public int RefId { get; set; }

    public string? Sfile { get; set; }

    public string? RefPrm { get; set; }

    public bool Starred { get; set; }

    public bool UnRead { get; set; }

    public string? Grup { get; set; }

    public string? Status { get; set; }

    public string? MailTo { get; set; }

    public string? MailFrom { get; set; }

    public string? MailTitle { get; set; }

    public string? MailSubject { get; set; }

    public string? MailBody { get; set; }

    public string? UserName { get; set; }

    public string UserImage { get; set; } = null!;

    public string? UserSign { get; set; }

    public string? Attachment { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }
}
