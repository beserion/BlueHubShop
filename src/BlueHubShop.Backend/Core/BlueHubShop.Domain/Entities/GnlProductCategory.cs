using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlProductCategory
{
    public int Id { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryName { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CompanyId { get; set; }

    public bool Active { get; set; }

    public string? Tkey { get; set; }

    public int ProductGroupId { get; set; }

    public int? ProductId { get; set; }

    public string? Description { get; set; }

    public int? DisplayOrder { get; set; }

    public string? Style { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<GnlProduct> GnlProducts { get; set; } = new List<GnlProduct>();
}
