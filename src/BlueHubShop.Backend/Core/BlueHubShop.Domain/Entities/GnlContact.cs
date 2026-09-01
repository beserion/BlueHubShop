using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlContact
{
    public int Id { get; set; }

    public string? RefCode { get; set; }

    public string? ContactCode { get; set; }

    public string? ContactName { get; set; }

    public string? ContactTitle { get; set; }

    public string? ContactRank { get; set; }

    public string? ContactType { get; set; }

    public bool? Active { get; set; }

    public decimal? Salery { get; set; }

    public string? Role { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? MobilPhone { get; set; }

    public string? WhatsUp { get; set; }

    public string? Facebook { get; set; }

    public DateTime? JoiningDate { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostCode { get; set; }

    public string? Street { get; set; }

    public string? Address { get; set; }

    public string? PhotoFile { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Gender { get; set; }

    public bool? ContactActive { get; set; }
}
