using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlImage
{
    public int Id { get; set; }

    public string? RefCode { get; set; }

    public string? FileName { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int Sequence { get; set; }
}
