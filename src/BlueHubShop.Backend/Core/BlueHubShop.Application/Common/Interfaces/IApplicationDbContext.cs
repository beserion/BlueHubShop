using Microsoft.EntityFrameworkCore;
using BlueHubShop.Domain.Entities;

namespace BlueHubShop.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<GnlProduct> GnlProducts { get; }
    DbSet<GnlCompany> GnlCompanies { get; }
    DbSet<GnlProductPrice> GnlProductPrices { get; }
    DbSet<GnlProductCategory> GnlProductCategories { get; }
    DbSet<GnlCategory> GnlCategories { get; }
    DbSet<ReqRequestSupplierProduct> ReqRequestSupplierProducts { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
