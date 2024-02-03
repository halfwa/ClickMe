using Microsoft.EntityFrameworkCore;
using ClickMe.App.Models;

namespace ClickMe.DAL;

internal sealed class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    public DbSet<UrlEntity> UrlEntities { get; set; }
}
