using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ReqPicker
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public string? Origin { get; set; }

    public string? PickerCode { get; set; }

    public string? DocumentNo { get; set; }

    public DateTime? ActionDate { get; set; }

    public DateTime? ReadyDate { get; set; }

    public string? Description { get; set; }

    public string? VesselName { get; set; }

    public string? PickerName { get; set; }

    public string? PreparedBy { get; set; }

    public string? Status { get; set; }

    public string? Currency { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Pqty { get; set; }

    public string? Submitter { get; set; }

    public string? ReceivedBy { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryRemark { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsCanceled { get; set; }

    public decimal? Rqty { get; set; }

    public int? TrackingTypeId { get; set; }

    public int? SupplierId { get; set; }
}
