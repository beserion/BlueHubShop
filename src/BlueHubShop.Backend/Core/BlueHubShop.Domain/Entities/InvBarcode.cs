using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvBarcode
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? StockId { get; set; }

    public string? BarcodeValue { get; set; }

    public string? Qrcode { get; set; }

    public int? BarcodeType { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsPrimary { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlCompany? Company { get; set; }
}
