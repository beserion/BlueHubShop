using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class OfferApprovalToken
{
    public int Id { get; set; }

    public int OfferId { get; set; }

    public Guid Token { get; set; }

    public string RecipientEmail { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public bool IsUsed { get; set; }

    public DateTime? UsedDate { get; set; }

    public string? ClientIp { get; set; }

    public string? UserAgent { get; set; }

    public string? CustomerNotes { get; set; }

    public string? SigneeName { get; set; }

    public string? SignatureData { get; set; }

    public int? CompanyId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ReqOffer Offer { get; set; } = null!;
}
