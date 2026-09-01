using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class InvBatchSerial
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? WarehouseId { get; set; }

    public int? VesselWarehouseId { get; set; }

    public int? StockId { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNo { get; set; }

    public DateTime? ProductionDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? Qty { get; set; }

    public string? Location { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? GoodsReceiptId { get; set; }

    public decimal InitialQuantity { get; set; }

    public string? Origin { get; set; }

    public string? Status { get; set; }

    public string? SupplierBatchNo { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual InvWarehouse? Warehouse { get; set; }
}
