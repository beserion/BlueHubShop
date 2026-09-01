using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public int? BranchId { get; set; }

    public int UserId { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public string? PartnerName { get; set; }

    public string? Department { get; set; }

    public bool? Admin { get; set; }

    public bool? Active { get; set; }

    public string? RefType { get; set; }

    public int? RefId { get; set; }

    public string? RefName { get; set; }

    public string? Name { get; set; }

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool? EmailConfirmed { get; set; }

    public string? Pswd { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? PhoneNumberConfirmed { get; set; }

    public bool? TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool? LockoutEnabled { get; set; }

    public int? AccessFailedCount { get; set; }

    public string? Photo { get; set; }

    public int? ContactId { get; set; }

    public string? Discriminator { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? Status { get; set; }

    public string? CurrentSessionKey { get; set; }
}
