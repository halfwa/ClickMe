using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ClickMe.App.Models;

namespace ClickMe.DAL.Configurations;

internal class UrlEntityConfiguration : IEntityTypeConfiguration<UrlEntity>
{
    public void Configure(EntityTypeBuilder<UrlEntity> builder)
    {
        throw new NotImplementedException();
    }
}
