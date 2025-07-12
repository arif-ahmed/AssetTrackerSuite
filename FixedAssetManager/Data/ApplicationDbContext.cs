using FixedAssetManager.Models;
using Microsoft.EntityFrameworkCore;

namespace FixedAssetManager.Data;
// Data/ApplicationDbContext.cs
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Asset> Assets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>().HasData(
            new Asset
            {
                Id = 1,
                AssetName = "Office Laptop",
                Category = "Equipment",
                PurchaseDate = new DateTime(2022, 1, 1),
                PurchaseValue = 100000,
                UsefulLifeYears = 5
            },
            new Asset
            {
                Id = 2,
                AssetName = "Office Chair",
                Category = "Furniture",
                PurchaseDate = new DateTime(2023, 6, 15),
                PurchaseValue = 20000,
                UsefulLifeYears = 10
            }
        );
    }
}

