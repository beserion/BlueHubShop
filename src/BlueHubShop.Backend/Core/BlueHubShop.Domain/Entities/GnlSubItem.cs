using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlSubItem
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public int? SubCategoryId { get; set; }

    public string? Grup { get; set; }

    public string? CategoryName { get; set; }

    public string? SubCategoryName { get; set; }

    public string? SubItemName { get; set; }

    public int? DisplayOrder { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
