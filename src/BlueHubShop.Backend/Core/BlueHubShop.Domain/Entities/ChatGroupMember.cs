using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ChatGroupMember
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string UserId { get; set; } = null!;

    public string Role { get; set; } = null!;

    public bool IsMuted { get; set; }

    public DateTime JoinedAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ChatGroup Group { get; set; } = null!;
}
