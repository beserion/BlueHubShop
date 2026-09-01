using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class AspNetUserRole
{
    public string UserId { get; set; } = null!;

    public string RoleId { get; set; } = null!;
}
