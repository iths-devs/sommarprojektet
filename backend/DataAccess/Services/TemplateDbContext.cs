using Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class TemplateDbContext : DbContext
{
    public DbSet<TemplateData> Templates => Set<TemplateData>();

    public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
    { }
    
    // This is for seeding the InMemoryDatabase
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TemplateData>().HasData(
            new TemplateData
            {
                Id = 1,
                Value = "Template1"
            },
            new TemplateData
            {
                Id = 2,
                Value = "Template2"
            },
            new TemplateData
            {
                Id = 3,
                Value = "Template3"
            });
    }
}