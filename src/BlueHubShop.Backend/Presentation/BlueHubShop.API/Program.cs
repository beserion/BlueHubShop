using Microsoft.EntityFrameworkCore;
using BlueHubShop.Application.Common.Interfaces;
using BlueHubShop.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();

// Add OpenAPI / Swagger
builder.Services.AddOpenApi();

// Add In-Memory Caching
builder.Services.AddMemoryCache();

// Add Permissive CORS Policy for Next.js Frontend Development
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.SetIsOriginAllowed(origin => true)
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

// Register EF Core DbContext
builder.Services.AddDbContext<BlueHubShopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStrMainDevelopment")));

// Register IApplicationDbContext
builder.Services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<BlueHubShopDbContext>());

// Register MediatR from Application Assembly
builder.Services.AddMediatR(cfg => 
    cfg.RegisterServicesFromAssembly(typeof(BlueHubShop.Application.DTOs.ProductDto).Assembly));

var app = builder.Build();

// 1. MUST BE FIRST: CORS before any redirections or authentication
app.UseCors("AllowFrontend");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
