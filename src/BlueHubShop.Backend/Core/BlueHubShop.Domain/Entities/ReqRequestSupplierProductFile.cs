using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqRequestSupplierProductFile
{
    public int Id { get; set; }

    public int? RequestDetailId { get; set; }

    public int? RequestSupplierProductId { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public string? Category { get; set; }

    public int? CompanyId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
