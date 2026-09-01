using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class EmailQueue
{
    public long Id { get; set; }

    public string? ProfileName { get; set; }

    public string? Recipients { get; set; }

    public string? CopyRecipients { get; set; }

    public string? BlindCopyRecipients { get; set; }

    public string? FromAddress { get; set; }

    public string? ReplyTo { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? BodyFormat { get; set; }

    public string? Importance { get; set; }

    public string? Sensitivity { get; set; }

    public string? FileAttachments { get; set; }

    public string? Query { get; set; }

    public string? ExecuteQueryDatabase { get; set; }

    public bool? AttachQueryResultAsFile { get; set; }

    public string? QueryAttachmentFilename { get; set; }

    public bool? QueryResultHeader { get; set; }

    public int? QueryResultWidth { get; set; }

    public string? QueryResultSeparator { get; set; }

    public bool? ExcludeQueryOutput { get; set; }

    public bool? AppendQueryError { get; set; }

    public bool? QueryNoTruncate { get; set; }

    public bool? QueryResultNoPadding { get; set; }

    public int? MailitemId { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? SentDate { get; set; }

    public string? SentStatus { get; set; }

    public int? SendAttempts { get; set; }

    public int? RetryAttempts { get; set; }

    public string? Refcode { get; set; }

    public int? Partnerid { get; set; }

    public bool? Starred { get; set; }

    public bool? UnRead { get; set; }

    public string? Status { get; set; }

    public string? Group { get; set; }

    public string? User { get; set; }

    public short? ErrType { get; set; }

    public string? ErrMsg { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsReported { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
