using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlEquipment
{
    public int Id { get; set; }

    public int? VesselId { get; set; }

    public int? PartnerId { get; set; }

    public string? VesselCode { get; set; }

    public string? PartnerCode { get; set; }

    public string? Category { get; set; }

    public string? EquipmentName { get; set; }

    public string? Description { get; set; }

    public string? Marka { get; set; }

    public string? Model { get; set; }

    public string? SerialNo { get; set; }

    public string? Status { get; set; }

    public string? Photo { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
