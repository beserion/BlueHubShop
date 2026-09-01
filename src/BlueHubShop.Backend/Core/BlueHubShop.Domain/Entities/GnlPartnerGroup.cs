using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPartnerGroup
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string GroupCode { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public int? ParentGroupId { get; set; }

    public string Color { get; set; } = null!;

    public string? Icon { get; set; }

    public int SortOrder { get; set; }

    public bool IsActive { get; set; }

    public decimal? DefaultCreditLimit { get; set; }

    public int? DefaultPaymentTerms { get; set; }

    public decimal? DefaultDiscountRate { get; set; }

    public string? DefaultCurrency { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<GnlPartnerGroupAssignment> GnlPartnerGroupAssignments { get; set; } = new List<GnlPartnerGroupAssignment>();

    public virtual ICollection<GnlPartnerGroup> InverseParentGroup { get; set; } = new List<GnlPartnerGroup>();

    public virtual GnlPartnerGroup? ParentGroup { get; set; }
}
