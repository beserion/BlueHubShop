using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlStore
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public int? CompanyId { get; set; }

    public int? StoreType { get; set; }

    public bool? Xmlshow { get; set; }

    public string? StoreCode { get; set; }

    public string? StoreName { get; set; }

    public string? Address { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Town { get; set; }

    public string? PostalCode { get; set; }

    public string? Email { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? Photo { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<ReqOrderDetail> ReqOrderDetails { get; set; } = new List<ReqOrderDetail>();
}
