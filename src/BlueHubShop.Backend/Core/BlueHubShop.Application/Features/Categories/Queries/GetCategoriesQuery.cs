using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using BlueHubShop.Application.Common.Interfaces;
using BlueHubShop.Application.DTOs;

namespace BlueHubShop.Application.Features.Categories.Queries;

public record GetCategoriesQuery : IRequest<List<CategoryDto>>;

public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<CategoryDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMemoryCache _cache;

    public GetCategoriesQueryHandler(IApplicationDbContext context, IMemoryCache cache)
    {
        _context = context;
        _cache = cache;
    }

    public async Task<List<CategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        const string cacheKey = "categories_all";

        if (_cache.TryGetValue(cacheKey, out List<CategoryDto>? cached) && cached != null)
        {
            return cached;
        }

        var categories = await _context.GnlProductCategories
            .AsNoTracking()
            .Where(c => c.Active && c.IsDeleted != true)
            .OrderBy(c => c.DisplayOrder)
            .Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.CategoryName ?? "Marine Category",
                Code = c.CategoryCode,
                Description = c.Description,
                Image = c.Image,
                ProductCount = c.GnlProducts.Count(p => p.IsDeleted != true && p.Active != false)
            })
            .ToListAsync(cancellationToken);

        if (!categories.Any())
        {
            var rawCategories = await _context.GnlProducts
                .AsNoTracking()
                .Where(p => !string.IsNullOrEmpty(p.Category) && p.IsDeleted != true)
                .GroupBy(p => p.Category!)
                .Select(g => new
                {
                    Name = g.Key,
                    ProductCount = g.Count()
                })
                .Take(50)
                .ToListAsync(cancellationToken);

            categories = rawCategories.Select((g, idx) => new CategoryDto
            {
                Id = idx + 1,
                Name = g.Name,
                ProductCount = g.ProductCount,
                Description = $"{g.Name} category technical equipment and spares."
            }).ToList();
        }

        _cache.Set(cacheKey, categories, TimeSpan.FromMinutes(10));
        return categories;
    }
}
