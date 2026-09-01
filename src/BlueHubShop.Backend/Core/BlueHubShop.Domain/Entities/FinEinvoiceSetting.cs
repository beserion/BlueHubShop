using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinEinvoiceSetting
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? ApiKey { get; set; }

    public string? SecretKey { get; set; }

    public string? UsernameEncrypted { get; set; }

    public string? PasswordEncrypted { get; set; }

    public string? AccessToken { get; set; }

    public DateTime? TokenExpiry { get; set; }

    public string? Environment { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Integrator { get; set; }

    public string? EdmUsername { get; set; }

    public string? EdmPassword { get; set; }

    public string? EdmEnvironment { get; set; }

    public string? EdmSessionId { get; set; }

    public DateTime? EdmSessionExpiry { get; set; }

    public string? InvoiceXsltFileName { get; set; }

    public string? EarchiveXsltFileName { get; set; }
}
