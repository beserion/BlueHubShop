using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiConversation
{
    public long Id { get; set; }

    public Guid ConversationGuid { get; set; }

    public int CompanyId { get; set; }

    public int BranchId { get; set; }

    public int? VesselId { get; set; }

    public int UserId { get; set; }

    public int? AgentId { get; set; }

    public string? Title { get; set; }

    public bool IsPinned { get; set; }

    public bool IsArchived { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
