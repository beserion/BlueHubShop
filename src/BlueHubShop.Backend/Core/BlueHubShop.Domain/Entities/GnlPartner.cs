using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlPartner
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? ShipmentId { get; set; }

    public bool? Active { get; set; }

    public int? GroupId { get; set; }

    public string? GroupName { get; set; }

    public bool? GroupPartner { get; set; }

    public string? OwnerName { get; set; }

    public string? CompanyCode { get; set; }

    public int? AccountPlanId { get; set; }

    public string? AccountRole { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public int? PartnerType { get; set; }

    public string? PartnerCode { get; set; }

    public string? PartnerName { get; set; }

    public string? ContactPerson { get; set; }

    public string? ShortName { get; set; }

    public string? Description { get; set; }

    public int? SectorId { get; set; }

    public int? SubSectorId { get; set; }

    public string? Title { get; set; }

    public string? Type { get; set; }

    public string? Kind { get; set; }

    public decimal? Balance { get; set; }

    public string? Mail { get; set; }

    public string? Phone { get; set; }

    public string? OfficePhone { get; set; }

    public string? OfficeFax { get; set; }

    public string? WebAddress { get; set; }

    public string? TaxNumber { get; set; }

    public string? TaxOffice { get; set; }

    public DateTime? JoiningDate { get; set; }

    public string? PartnerInfo { get; set; }

    public int? Comissier { get; set; }

    public bool? ComissierActive { get; set; }

    public string? AccountManager { get; set; }

    public string? AccountEmail { get; set; }

    public decimal? CreditLimit { get; set; }

    public int? PaymentTerm { get; set; }

    public string? OfficeAddress { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DueDays { get; set; }

    public int? PaymentTerms { get; set; }

    public string? InvoiceAddress { get; set; }

    public string? InvoiceType { get; set; }

    public string? Currency { get; set; }

    public string? RelevantPerson { get; set; }

    public string? RelevantPersonGender { get; set; }

    public bool? Abroad { get; set; }

    public string? Remark { get; set; }

    public string? Country { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public bool? Approved { get; set; }

    public DateOnly? ApprovedDate { get; set; }

    public string? City { get; set; }

    public string? ContactTitle { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }

    public string? District { get; set; }

    public string? EmailAddress { get; set; }

    public string? FaxNo { get; set; }

    public string? IdentityNo { get; set; }

    public string? MobilePhone { get; set; }

    public string? Notes { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public int? Rating { get; set; }

    public string? Sector { get; set; }

    public string? Photo { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? AccountCodeBuyer { get; set; }

    public string? AccountCodeSupplier { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsAbroad { get; set; }

    public bool IsSelf { get; set; }

    public virtual ICollection<GnlPartnerContact> GnlPartnerContacts { get; set; } = new List<GnlPartnerContact>();

    public virtual ICollection<ScmAppointment> ScmAppointments { get; set; } = new List<ScmAppointment>();
}
