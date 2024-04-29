using System;
using Microsoft.EntityFrameworkCore;

namespace DsK.WebAPIMixedTokenAndAPIKey.Entity;

public class MyAppDbContext : DbContext
{
    public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
    : base(options)
    {
    }

    public DbSet<ApiKey> ApiKeys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional configuration can go here, such as configuring indexes for better search performance
        modelBuilder.Entity<ApiKey>()
            .HasIndex(apiKey => apiKey.Key)
            .IsUnique();  // Ensures that each API key is unique
    }
}