using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlDocument
{
    public int Id { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? Grup { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? DocumentCode { get; set; }

    public string? DocumentName { get; set; }

    public string? Description { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
