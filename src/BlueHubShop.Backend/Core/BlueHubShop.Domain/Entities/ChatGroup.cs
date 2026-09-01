using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ChatGroup
{
    public int Id { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public string? GroupAvatarUrl { get; set; }

    public string? OwnerUserId { get; set; }

    public bool IsPrivate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<ChatGroupMember> ChatGroupMembers { get; set; } = new List<ChatGroupMember>();

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();
}
