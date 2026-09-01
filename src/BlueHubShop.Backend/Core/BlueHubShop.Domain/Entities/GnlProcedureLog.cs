using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlProcedureLog
{
    public int Id { get; set; }

    public int? ProcedureId { get; set; }

    public string? ScriptText { get; set; }

    public string? ExecutedBy { get; set; }

    public DateTime? ExecutedDate { get; set; }

    public string? ResultMessage { get; set; }

    public bool? IsSuccess { get; set; }
}
