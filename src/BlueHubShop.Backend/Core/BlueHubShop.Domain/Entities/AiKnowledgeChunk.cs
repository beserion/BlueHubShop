using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AiKnowledgeChunk
{
    public long Id { get; set; }

    public int KnowledgeBaseId { get; set; }

    public int ChunkNo { get; set; }

    public string ChunkText { get; set; } = null!;

    public string? ChunkSummary { get; set; }

    public string? Keywords { get; set; }

    public string? EmbeddingVector { get; set; }

    public int TokenCount { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual AiKnowledgeBasis KnowledgeBase { get; set; } = null!;
}
